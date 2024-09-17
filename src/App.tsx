import { useState } from "react";
import NumberConverter from "./components/NumberConverter";

function App() {
  const [words, setWords] = useState("");

  return (
    <>
      <h1>Convert numbers to words</h1>
      <NumberConverter onConvert={(data) => setWords(data?.words ?? "")} />
      <p>{words}</p>
    </>
  );
}

export default App;
