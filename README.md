# Make the most of GitHub Copilot, your new AI pair programmer
Agenda:
- Working with an AI: Make sure you are getting the best results from your AI partner by using it's Agents capabilities.
- Reduce repetitive tasks: GitHub Copilot can help developers spend less time on creating boilerplate, freeing up time to work on more important tasks.
- Simplify code refinement and debugging: GitHub Copilot offers in-depth analysis on how code works. Use your Copilot to help fix exceptions and debug statements.


## Working with an AI (10min)


## Reduce repetitive tasks (15min)


## Simplify code refinement and debugging (15min)


## Closing
### Asking for more context
Asking for more context in Copilot prompting means:
Giving Details: Instead of saying "Make a function," you might say, "Make a function that calculates the total price after sales tax." This helps Copilot know exactly what you want.
Clarifying Requirements: If you need your code to follow certain rules or use specific tools, tell Copilot upfront. Like, "Using JavaScript, make a function that calculates age from a birthdate."
Answering Questions: Sometimes, Copilot might ask for clarification if it's unsure. Responding to these questions can help refine the results you get.

The more information you provide, the better Copilot can assist you. It's like giving more pieces to a puzzle, helping to create a clearer picture!

### Prompting

https://github.com/f/awesome-chatgpt-prompts

Role Prompting - Here we discuss having Copilot take on a role when completing a task.
"I want you to act as a front end developer coach. I will provide some questions and the task that I have to complete and would like for you to walk me through the process before our sprint due date. This could involve offering advice on various topics, such as utilizing the react framework or handling API calls. My first request is to help setup my development environment."

This tends to improve the results because it focuses the AI model on only the information it would have in that current role. It takes on that persona and alters the way that the model would present information.

Combining Role prompting with asking for context can yield even better results.
For example: "If I have not given you enough information, please let me know what information is missing to make a better decision."

Overcoming the token limit in GitHub Copilot requires understanding how the underlying model (like GPT-3 or GPT-4) processes and generates text. A token in OpenAI's models is roughly equivalent to a word or character, and there's a maximum number of tokens that these models can handle in a single request. If you exceed this limit, you won't get the desired output or might face errors.
Here are some strategies to address the token limit in GitHub Copilot:

Break Down Tasks: Instead of asking Copilot to generate a large block of code in one go, ask it to produce smaller, specific pieces of code one at a time. This not only helps in staying within the token limit but also ensures that each piece of generated code is accurate and relevant.
Be Concise: Be precise in your prompts. Remove any unnecessary verbiage. While it's good to provide context, ensure it's concise.
Iterative Development: Use the output from one prompt as the starting point for another. This way, you can progressively build up more complex solutions without trying to get it all in one shot.
Post-Processing: Sometimes, you might get repetitive or verbose code from Copilot. You can manually refactor or trim down the generated code after the fact.
Stay Updated: As AI and Copilot evolve, there might be changes or enhancements in how the system handles tokens or how it optimizes its outputs. It's essential to keep track of any updates or best practices provided by GitHub or OpenAI regarding Copilot.
Feedback Loop: If you find that certain prompts consistently result in exceeding the token limit, provide feedback through the Copilot interface. Over time, this can lead to improvements in how Copilot generates code relative to token constraints.