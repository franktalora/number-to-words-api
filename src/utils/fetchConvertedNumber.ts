export type ConvertedNumberDataProps = {
  words: string;
  number: string;
}

export const fetchConvertedNumber = async (numberToConvert: string) => {
  if (!numberToConvert) {
    throw new Error("Please enter a number");
  }

  const response = await fetch(
    `http://localhost:5290/number-to-words/${numberToConvert}`
  );
  if (!response.ok) {
    throw new Error("Failed to convert number");
  }
  const data: ConvertedNumberDataProps = await response.json();

  return data;
};
