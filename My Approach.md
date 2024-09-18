
A document outlining the reasons why I selected my approach, and why I decided against other possible solutions.

# How did I achieve the Submission Requirements?
1. *Produce the quality of work and user interface that you’d consider acceptable for a customer*
  -  For the user interface, I've made use of Tailwind to help produce a decent-looking UI. It just made it a lot faster/convenient for me to do.
  -  I've also considered several other aspects that would be helpful for a user, such as the ability to copy the converted words to clipboard, and a 'history' of current conversions.
  -  Other aspects of UX have been thoroughly kept-in-mind, such as accessibility: contrast of colours, 'convert' button is clear, input is readable.
2. *Don’t use the internet to find part of, or the whole, solution. We’re familiar with solutions from the internet and we’re keen to assess your unique analysis, design and coding skills.*
  - As I have not formally worked with C#, referring to online documentation was unavoidable. I required guidance on setting up the project with `dotnet`, running it, implementing tests, as well as getting C# Dev Kit to work in VS Code.
  - The actual money and price converter functions were designed and written by me. Again, some Googling and ChatGPTing was required to figure out certain things, such as how to run specific Math functions in C# (they differ somewhat to JS), and language specs, such as types and using namespaces. VS Code plugins made other things, such as formatting, convenient.
3. *Please come up with your own solution/algorithm by not using any existing libraries, nuget packages, or generative AI*
  - Again, the money/price conversion algorithms, as well as the entire React/JS UI, were created by me. I approached the algorithms the same as if I were to write them in TypeScript.

# Why C#/.NET?

I decided on using C# for the backend because:
  1. It's more relevant to the role, and I would be using it in Technology One's stack!
  3. I hadn't used it before in a project, and so I wanted to learn something new (and very important) on my path to Fullstack expertise
  2. It was noted as being "preferable" for the task
  4. I wanted to prove myself and outdo my own expectations

> I decided that using Java for this project, although I already had some experience with it, wouldn't be as beneficial compared to C# due to the reasons above.

I ultimately found it super easy to work with. I found it flexible (re. declaring namespaces and private/public classes), and the general syntax easy to read and understand (especially with type declerations).
Not only that, I found it boringly quick and easy to set up (used `dotnet new webapi`), and hit a lot less snags than I'm used to compared to a TS/React project.

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

# Why Fetch API for data retrieval?

Essentially, because it's super simple, natively supported in modern browsers, and doesn't require anything else. 

Axios was considered "just because I could", but this would definitely be overkill and a time-sink.

# Why Tailwind CSS?

I'm quite used to working with Tailwind for both React and React Native projects. I find that it's a lot more easy to manage, and a lot less verbose, than either having to manage .css files (with a tonne of classnames) or CSS-in-JS (React CSS). 
I also find it a lot quicker and easier to whip up a decent-looking UI. I wouldn't consider anything else.

> I may also consider Styled Components, which makes managing smaller React components a bit easier, especially when they need to be re-used.
> However, I once implemented Tailwind into styled components for a React Native project.

# Other things I considered...
  - File/folder name conventions
    - Honestly wasn't sure what convention to use for the backend project. In future C# projects, I will use PascalCase, since that seems to be the standard.
  - An `env` file to store things globally, such as the API URI
    - Although helpful, I found this unnecessary since this project is already super simple
