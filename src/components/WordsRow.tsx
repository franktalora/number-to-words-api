import React from "react";
import { ConvertedNumberDataProps } from "../api/fetchConvertedNumber";

export interface WordsRowProps extends ConvertedNumberDataProps {
  rowKey: number;
}

const WordsRow = ({
  words,
  number,
  isFirst,
}: WordsRowProps & { isFirst: boolean }) => {
  return (
    <div
      className={`border border-gray-700 rounded-xl px-3 py-2 text-left transition-colors max-w-screen-sm hover:border-gray-500 ${
        !isFirst && "opacity-50 hover:opacity-100"
      }`}
    >
      <p className="bg-gray-800 text-gray-400 font-bold rounded-full p-1 px-3 text-sm inline-block mr-3">
        ${number} =
      </p>
      <p className="text-left font-bold text-lg inline-block leading-tight my-2">
        {words}
      </p>
    </div>
  );
};

export default React.memo(
  WordsRow,
  (prev, next) => prev.rowKey === next.rowKey && prev.isFirst === next.isFirst
);
