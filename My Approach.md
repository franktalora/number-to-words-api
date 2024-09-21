
A document outlining the reasons why I selected my approach, and why I decided against other possible solutions.

# How did I achieve the Submission Requirements?
1. *Produce the quality of work and user interface that you’d consider acceptable for a customer*
    -  For the user interface, I've made use of Tailwind to help produce a decent-looking UI. Tailwind also made it a lot faster/convenient for me to produce.
    -  I've also considered several other aspects that would be helpful for a user, such as the ability to copy the converted words to clipboard, and a 'history' of current conversions.
    -  Other aspects of UX have been thoroughly kept-in-mind, such as accessibility: contrast of colours, 'convert' button is clear, input is readable.
  
2. *Don’t use the internet to find part of, or the whole, solution. We’re familiar with solutions from the internet and we’re keen to assess your unique analysis, design and coding skills.*
    - As I have had limited experience with C#, referring to online documentation was unavoidable. I referred to documentation on setting up the project with `dotnet`, running the solution, implementing tests, as well as guidance on the C# Dev Kit for VS Code.
    - The logic for the money and price converter functions were designed and written by me. While I did consult external resources to understand C#'s Math functions (they differ somewhat to JS), and language specs/syntax, such as types and using namespaces, the algorithm itself and the overall solution were entirely my own work. VS Code plugins helped with formatting and intellisense.

3. *Please come up with your own solution/algorithm by not using any existing libraries, nuget packages, or generative AI*
    - The money/price conversion algorithms and the entire React web page UI were implemented from scratch. I approached the algorithms the same as if I were to write them in TypeScript. The UI development was straightforward due to my familiarity with React.

# Why C#/.NET?

I decided on using C# for the backend because:
  1. It's more relevant to the role, and I would be using it in Technology One's stack alongside React/React Native!
  3. I hadn't used it before in a project, and so I wanted to learn something new (and very important) on my path to Fullstack expertise
  2. It was noted as being "preferable" for the task
  4. I wanted to prove myself and outdo my own expectations

> I decided that using Java for this project, although I already had some experience with it, wouldn't be as beneficial compared to C# due to the reasons above.

I ultimately found it super easy to work with. I found it flexible (eg. declaring namespaces and private/public classes is a breeze compared to importing/exporting in React), and the general syntax easy to read and understand (especially with type declerations). Although, I didn't find the syntax much different compared to Java.
Not only that, I found it boringly quick to set up (used `dotnet new webapi` to produce a template to work from), and hit a lot less snags than I'm used to compared to a TS/React project (eg. node modules, configs, setup, etc. can often be flakey).

***Any trouble?***

As I'm using a mac, I'm not able to use Visual Studio, so had to use VS Code with the official *C# Dev Kit*. Albeit a bit buggy, I found this fairly easy to work with however, and was eventually able to make it work with debugging and my unit tests.

> .NET seems to have the magical ability to fix itself when something goes wrong(?). It seems that all I needed to do was run `dotnet run` and things just *worked*

# Why unit testing with xUnit for the backend?

I ended up using xEdit as I found it was already well-integrated with the .NET environment, and seemed pretty similar to what I was already used to in Jest.

***Why no frontend tests (yet)?***

Vite doesn't support Jest out-of-the-box, and so needed some manual setting up to get it working.

> Manual configuration of Jest is honestly time-consuming, as it has a tonne of configuration knobs you need to set manually.
> Not only that, but you need to introduce babel, which also requires more manual tweaking.
> So, ultimately, I decided against implementing it for now. I've left a TODO note in the readme to note for future.

# Why Vite for the frontend?

From experience, Vite makes it easy to get a simple React website up and running. 

There are other solutions, such as Next.JS, Gatsby, Webpack, etc. but these are designed for more complex projects (especially Next). I have used all of these in the past, and Vite was always the go-to for a straightforward project such as this one. It ultimately proved itself to work quite well with .NET as well.

# Why Fetch API for data retrieval?

Essentially, because it's super simple, natively supported in modern browsers, and doesn't require anything else. 

> Axios was considered "just because", but this would definitely be "overkill" and a time-sink.

# Why Tailwind CSS?

I’m very accustomed to using Tailwind for both React and React Native projects, and prefer it to other styling methods. I find that it's a lot more easy to manage, and far less verbose, compared to traditional `.css` files (with often requires a tonne of class names) or CSS-in-JS (React CSS). 
I also find it a lot quicker and easier to whip up a decent-looking UI. I wouldn't consider anything else.

> That said, I would also consider Styled Components, which makes it especially easier to manage smaller React components that need to be reused frequently.
> However, I once implemented Tailwind into styled components for a React Native project, which gave us the best of both worlds.

# Other things I considered...

- I stopped at calculating whole billions.
    - I realise that the code of `GetBigNumber`, instead of iterating through different `if` statements based on the value amount, might instead benefit from something like a loop, or function that split the length of digits up into 1-3 digit chunks that could be calculated with `GetNumbers` and `GetHundreds`. However, since the task only called for calculating `123.45`, as an example, and nothing else, and because this could technically go on forever (infinite edge-cases for trillion, quadrillion, quintillion, etc etc.), I felt that 1 billion was a sufficient cap.
- Complexity
    - While building this project, I often questioned whether I was making it "too complex". However, I wanted to demonstrate my skill across multiple aspects of a project (backend API + frontend framework + UI design), so I decided to push myself a bit.
> [!NOTE]
> That said, I recognise that perfectionism is quite often unnecessary and time-consuming, and it's always a good practice to not hyperfocus on a single context. As a result, I've left this project "as-is", complete with some evident rough edges, to demonstrate that I can balance producing a strong result within a shorter timeframe than required, which leaves more time for bug-fixing, testing, and refinement, without getting bogged down in perfecting every detail.
- File/folder name conventions
    - I was unsure what convention to use for a .NET project. In future C# projects, I will use PascalCase, since that seems to be the standard.
- An `env` file to store things globally, such as the API URI
    - Although helpful, I found this unnecessary since this project is already super simple
