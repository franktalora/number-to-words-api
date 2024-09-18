import { useRef, useState } from "react";
import {
  ConvertedNumberDataProps,
  fetchConvertedNumber,
} from "../api/fetchConvertedNumber";

interface NumberConverterProps extends React.HTMLAttributes<HTMLDivElement> {
  onConvert: (data: ConvertedNumberDataProps | null) => void;
}

// Max number is 1 billion, since anything over doesn't work atm
// TODO: Fix number converter to parse 1 billion+
const MAX_VALUE = 1000000000;

const getFormattedValue = (value: string): string => {
  let parsedValue = parseFloat(value.replace("$", ""));
  if (isNaN(parsedValue)) return value;

  if (parsedValue > MAX_VALUE) {
    parsedValue = MAX_VALUE;
  }

  // Format the value to 2 decimal places
  return "$" + parsedValue.toFixed(2).replace(/\.00$/, "");
};

const NumberConverter = ({
  onConvert,
  className = "",
  ...otherProps
}: NumberConverterProps) => {
  const inputRef = useRef<HTMLInputElement>(null);
  const [error, setError] = useState("");

  const setConvertedNumber = async () => {
    const value = inputRef.current?.value.replace("$", "");
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
    <div className={`max-w-80 space-y-4 ${className}`} {...otherProps}>
      <input
        ref={inputRef}
        placeholder="Enter a number"
        onKeyDown={(e) => {
          if (e.key === "Enter") {
            const target = e.target as HTMLInputElement;
            target.value = getFormattedValue(target.value);
            setConvertedNumber();
          }
        }}
        onChange={(e) => {
          const value = e.target.value.replace("$", "");
          const parsedValue = parseFloat(value);
          if (!!value && isNaN(parsedValue)) {
            setError("Only number digits can be converted");
          } else {
            setError("");
          }
        }}
        onBlur={(e) => {
          e.target.value = getFormattedValue(e.target.value);
        }}
      />
      <div className="flex flex-row space-x-2 justify-center">
        <button onClick={setConvertedNumber}>Convert</button>
        <button
          className="button-outline"
          onClick={() => {
            if (inputRef.current) inputRef.current.value = "";
            onConvert(null);
            setError("");
          }}
        >
          Reset
        </button>
      </div>
      {error ? <p className="text-red-500">{error}</p> : null}
    </div>
  );
};

export default NumberConverter;
