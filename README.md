<img width="500" alt="Screenshot 2024-09-18 at 4 33 00 PM" src="https://github.com/user-attachments/assets/f34f3c72-a9bc-4256-ae89-492566f0a5fb">

# Price-to-Word Converter

> Also known as: "Dollars to (Cent)ences"

## Description

A web page that converts a numerical value into a price. 

## Tech Stack

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


## Created by Frank Talora

Contact me: [hello@franktalora.com](mailto:hello@franktalora.com)

