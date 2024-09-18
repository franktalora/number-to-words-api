import { useRef, useState } from "react";
import {
  ConvertedNumberDataProps,
  fetchConvertedNumber,
} from "../utils/fetchConvertedNumber";

interface NumberConverterProps {
  onConvert: (data: ConvertedNumberDataProps | null) => void;
}

// Max number is 1 billion, since anything over doesn't work atm
// TODO: Fix number converter to parse 1 billion+
const MAX_VALUE = 1000000000;

const getParsedValue = (value: string) => parseFloat(value.replace("$", ""));

const NumberConverter = ({ onConvert }: NumberConverterProps) => {
  const inputRef = useRef<HTMLInputElement>(null);
  const [error, setError] = useState("");

  const getConvertedNumber = async () => {
    const value = inputRef.current?.value;
    if (!value) {
      onConvert(null);
      return;
    }

    try {
      const convertedData = await fetchConvertedNumber(value);
      onConvert(convertedData);
      setError("");
    } catch (error) {
      onConvert(null);

      if (error instanceof Error) {
        setError(error.message);
      } else {
        setError("Failed to convert number");
      }
    }
  };

  return (
    <>
      <input
        ref={inputRef}
        placeholder="Enter a number"
        onChange={(e) => {
          const value = e.target.value;
          const parsedValue = getParsedValue(value);
          if (!!value && isNaN(parsedValue)) {
            setError("Only number digits can be converted");
          } else {
            setError("");
          }
        }}
        onBlur={(e) => {
          const parsedValue = getParsedValue(e.target.value);
          if (isNaN(parsedValue)) return;

          if (parsedValue > MAX_VALUE) {
            e.target.value = String(MAX_VALUE);
          } else {
            // Format the value to 2 decimal places
            e.target.value = parsedValue.toFixed(2);
          }

        }}
      />
      <button onClick={getConvertedNumber}>Convert</button>
      {error ? <p className="text-red-500">{error}</p> : null}
    </>
  );
};

export default NumberConverter;
