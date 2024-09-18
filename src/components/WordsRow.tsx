import React from "react";
import { ConvertedNumberDataProps } from "../api/fetchConvertedNumber";

export interface WordsRowProps extends ConvertedNumberDataProps {
  rowKey: number;
}

const CopyIcon = (props: React.SVGProps<SVGSVGElement>) => (
  <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" {...props}>
    <path d="M19,21H8V7H19M19,5H8A2,2 0 0,0 6,7V21A2,2 0 0,0 8,23H19A2,2 0 0,0 21,21V7A2,2 0 0,0 19,5M16,1H4A2,2 0 0,0 2,3V17H4V3H16V1Z" />
  </svg>
);

const WordsRow = ({
  words,
  number,
  isFirst,
}: WordsRowProps & { isFirst: boolean }) => {
  return (
    <div
      className={`flex flex-row border border-gray-700 rounded-xl px-3 py-2 text-left transition-colors max-w-screen-sm hover:border-gray-500 ${
        !isFirst && "opacity-50 hover:opacity-100"
      }`}
    >
      <div className="flex-1">
        <p className="bg-gray-800 text-gray-400 font-bold rounded-full p-1 px-3 text-sm inline-block mr-3">
          ${number} =
        </p>
        <p className="text-left font-bold text-lg inline-block leading-tight my-2">
          {words}
        </p>
      </div>
      <div
        className="self-end p-2 -mr-2 fill-slate-400 hover:fill-slate-200 active:fill-slate-600 cursor-pointer"
        onClick={() => navigator.clipboard.writeText(words)}
      >
        <CopyIcon className="size-5" />
      </div>
    </div>
  );
};

export default React.memo(
  WordsRow,
  (prev, next) => prev.rowKey === next.rowKey && prev.isFirst === next.isFirst
);
