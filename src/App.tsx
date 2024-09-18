import { useState } from "react";
import NumberConverter from "./components/NumberConverter";

function App() {
  const [words, setWords] = useState("");

  return (
    <>
      <h1 className="pb-2">Convert numbers to words</h1>
      <p>This tool allows you to convert numerical input into words.</p>
      <p className="italic">Max value of 1 billion</p>
      <NumberConverter onConvert={(data) => setWords(data?.words ?? "")} className="py-6" />
      <p>{words}</p>
    </>
  );
}

export default App;
