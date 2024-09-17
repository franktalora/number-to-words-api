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

  const getConvertedNumber = async () => {
    const convertedData = await handleConvert(number);
    console.log("convertedData", convertedData)
    return convertedData
  };

  return (
    <>
      <h1>Vite + React</h1>
      <div className="p-2">
        <input
          type="number"
          placeholder="Enter a number"
          value={number}
          onChange={(e) => setNumber(e.target.value)}
        />
        <button onClick={getConvertedNumber}>Convert</button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
    </>
  );
}

export default App;
