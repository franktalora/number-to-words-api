import { useState } from "react";
import {
  ConvertedNumberDataProps,
  fetchConvertedNumber,
} from "../utils/fetchConvertedNumber";

interface NumberConverterProps {
  onConvert: (data: ConvertedNumberDataProps | null) => void;
}

const NumberConverter = ({ onConvert }: NumberConverterProps) => {
  const [number, setNumber] = useState("");
  const [error, setError] = useState("")

  const getConvertedNumber = async () => {
    try {
      const convertedData = await fetchConvertedNumber(number);
      onConvert(convertedData);
      setError("");
    } catch (error) {
      onConvert(null);

      if (error instanceof Error) {
        setError(error.message);
      }
    }
  };

  return (
    <>
      <input
        type="number"
        placeholder="Enter a number"
        value={number}
        onChange={(e) => setNumber(e.target.value)}
      />
      <button onClick={getConvertedNumber}>Convert</button>
      {error ? <p className="text-red-500">{error}</p> : null}
    </>
  );
};

export default NumberConverter;
