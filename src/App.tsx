import { useState } from "react";
import NumberConverter from "./components/NumberConverter";
import WordsRow, { WordsRowProps } from "./components/WordsRow";

function App() {
  const [wordsArray, setWordsArray] = useState<WordsRowProps[]>([]);

  return (
    <>
      <div className="flex flex-col items-center px-4 pt-8 pb-2">
        <h1 className="pb-2">Price-to-word converter.</h1>
        <p className="mb-6 italic">Also known as Dollars to (Cent)ences</p>
        <p className="text-sm">Maximum value: 1 billion</p>
        <NumberConverter
          onConvert={(data) => {
            if (data === null) return;

            setWordsArray([
              { ...data, rowKey: wordsArray.length },
              ...wordsArray,
            ]);
          }}
          className="pt-4"
        />
      </div>
      <div className="flex flex-col overflow-y-scroll gap-3 px-4 pb-4 pt-6 w-full items-center after:block after:absolute after:w-full after:h-6 after:-mt-6 after:bg-gradient-to-b after:from-gray-950">
        {wordsArray.map((data, index) => {
          return <WordsRow key={data.rowKey} {...data} isFirst={index === 0} />;
        })}
      </div>
    </>
  );
}

export default App;
