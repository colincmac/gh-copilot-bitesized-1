# Working with an AI

### Demo Agents
GitHub Copilot is a collection of AI Agents designed to collect extra context either about a code base or a specific domain or technology. By using the appropriate agent, Copilot Chat can find and provide better information to send to the Copilot backend.

@workspace to ask about the opened project

@vscode to use the current IDE features

@terminal work with the default terminal


### Demo Plugins
Agents are made of several building blocks under the hood, however how you can interact with agents is by using their built in plugins.
Think of plugins as helping Copilot understand your intent.
They are executed via slash commands:

Generate search parameters. /search is a keyword that can be used to generate code related to searching for resources in an API or database. When you type /search in your editor, GitHub Copilot may suggest code snippets that can be used to perform a search operation, such as querying an API endpoint with search parameters or filtering a database query based on search criteria.

Bring a workspace to life by using the /createWorkspace commands in copilot chat. Ask for a popular project type with /createWorkspace by listing out the type of project you need. For example, if you need a reactjs application with a mongodb database, it will send back the folder structure you need. After looking over the workspace copilot creates for you, you can select “create workspace” to create and open the project directory as a new workspace.

Just a friendly note, if you are not see the option listed when you type /, make sure your copilot chat is switched to the pre-release version and updated to the newest version in your marketplace. This was a new upgrade added to the copilot family and you may not see the option listed if you have not updated or using the release version.

### Demo Context Variables
Context Variables provide extra context to your questions in chat by using the # symbol
The #selection context variable enables you to focus Copilot's suggestions on the specific text you select in the editor.
The #file variable lets you reference specific files from your workspace in your chat prompt. This helps make the answers from Copilot Chat more relevant to your code by providing context about the file you are working with. You can ask questions like "Can you suggest improvements to #file:package.json?" or "How do I add an extension in #file:devcontainer.json?". By using the #file variable, you can get more targeted and accurate responses from Copilot.
With the #editor context variable, you have control over whether to include the visible code of the active editor in your prompt to Copilot Chat. Previously, this information was automatically included when you hadn't selected text in the editor. Now, you can choose to explicitly add the visible code to the context or omit it for more general questions.
By combining the #file, #editor, and #selection variables, you have full control over the context you provide to Copilot Chat, ensuring that you receive the most relevant and helpful answers.

**In the next session, we'll demo how you can expand the context of your ask by using GitHub Copilot on your code**

### Closing
Even with the tooling behind it, one of AI's largest limitations is context.

