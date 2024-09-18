<img width="500" alt="Screenshot 2024-09-18 at 4 33 00 PM" src="https://github.com/user-attachments/assets/f34f3c72-a9bc-4256-ae89-492566f0a5fb">

# Price-to-Word Converter

> Also known as: "Dollars to (Cent)ences"

A simple web page that converts a numerical value into a price. 

**What's on offer?**
  - A web user interface in React to allow the conversion to be tested interactively
  - Input numbers and convert them to a price, both written (in caps) and in numerical form
    - eg. `123.45678` converts to `$123.46` and `ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-SIX CENTS`
  - Copy your converted numbers into your clipboard
  - A history of your conversions (reset on refresh or upon clicking 'Reset')

## Stack

**Front End:** 
  - React
  - Vite -- *For the localhost web server*
  - Tailwind -- *For styling*

**Back End:**
  - C#/.NET -- *For converting our numbers*
  - xUnit -- *For testing*

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (v8)
- [Node.js/npm](https://nodejs.org/)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/franktalora/number-to-words-api.git
   cd number-to-words-api

3. Set up the front end:
   ```bash
   npm install

## Running the application

Ensure that you're in the repo's root and run
```
npm run start
```

> This will:
> 1. Start the `dotnet` development server (listening on [http://localhost:5290](http://localhost:5290))
> 2. Launch Vite, and spin up the React web page.


Open [http://localhost:5173](http://localhost:5173) in your web browser

> Port `5173` is Vite's default. In case this doesn't work, check the console terminal

## Testing

Run `dotnet test` in the root or in `/@number-to-words-api-tests`

This will run several unit tests to test both the Number and Price converters. The testing tool used is [xUnit](https://xunit.net/).

<img width="400" alt="Screenshot 2024-09-18 at 4 31 09 PM" src="https://github.com/user-attachments/assets/1738bb3a-9f50-498d-906c-3ec633e5580a">

The test plan here is to ensure both number conversion (`123` -> `ONE HUNDRED AND TWENTY-THREE`) and price conversion (`1.50` -> `ONE DOLLAR AND FIFTY CENTS`).

So, whenever we run our endpoint on the frontend and input a valid `number`, we expect it to return with the number that was input, and the converted words.

> [!IMPORTANT]  
> TODO: Implement frontend tests.
> UI components would benefit from some (Jest) tests:
> Things such as number formatting (`123.45678` -> `$123.46`), copy to clipboard, and conversion history, are handled via JS.


## Created by Frank Talora

Contact me: [hello@franktalora.com](mailto:hello@franktalora.com)

