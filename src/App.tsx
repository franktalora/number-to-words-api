import { useState } from "react";

const handleConvert = async (numberToConvert: string) => {
  if (!numberToConvert) {
    throw new Error("Please enter a number");
  }

  const response = await fetch(
    `http://localhost:5290/number-to-words/${numberToConvert}`
  );
  if (!response.ok) {
    throw new Error("Failed to convert number");
  }
  const data: { words: string; number: string } = await response.json();

  return data;
};

function App() {
  const [number, setNumber] = useState("");
  const [words, setWords] = useState("");

  const getConvertedNumber = async () => {
    const convertedData = await handleConvert(number);
    console.log("convertedData", convertedData);
    setWords(convertedData.words);
  };

  return (
    <>
      <h1>Convert numbers to words</h1>
      <input
        type="number"
        placeholder="Enter a number"
        value={number}
        onChange={(e) => setNumber(e.target.value)}
      />
      <button onClick={getConvertedNumber}>Convert</button>
      <p>{words}</p>
    </>
  );
}

export default App;
