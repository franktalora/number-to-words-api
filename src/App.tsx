import { useState } from "react";
import NumberConverter from "./components/NumberConverter";

function App() {
  const [words, setWords] = useState("");

  return (
    <>
      <h1 className="pb-2">Price-to-word converter.</h1>
      <p className="mb-6 italic">
        Also known as Dollars to (cent)ences
      </p>
      <p>This tool allows you to convert numerical input into words.</p>
      <p className="font-bold">Max value: 1 billion</p>
      <NumberConverter
        onConvert={(data) => setWords(data?.words ?? "")}
        className="py-6"
      />
      <p>{words}</p>
    </>
  );
}

export default App;
