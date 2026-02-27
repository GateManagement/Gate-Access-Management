# Gate Access Management
This a garage storage management application with the ability to manage users, garages, as well as activity logging, active reporting, and much more!

## Getting Started
In order to start developing for this program, follow these steps
1. Download the Dotnet SDK from Microsoft v.8 or higher
2. Download Jetbrains Rider, Visual Studio, or Visual Studio Code
3. Install the Avalonia extension within the editor of your choice
4. Clone the repo
5. Make your own local branch

## How to Contribute
In order to contribute in a way that is easy for everyone to collaborate, follow these steps:
NOTE: You will be doing this for every set of changes made. Changes should be relevant to the branch you are working in. Many of these steps can be done within your chosen editor. I'm adding the commands because they are universal regardless of the editor chosen. DM me if you have questions about this.
1. In your local branch, commit the changes that you would like to push
    - Before you committing your changes, if you were working on main, you can create a local branch by running the following command in the terminal
        - `git checkout -b YOUR_NAME/YOUR_BRANCH_TITLE`
        - ex: `git checkout -b jordy/garage_ui_fixes`
2. Make sure to add your name at the end of your commit
    - ex: "Made changes to the garage ui and fixed the classes related to it - Jordy Benitez"
3. Commit your changes and push your local branch to origin
    - `git commit -m "Made changes to the garage ui and fixed the classes related to it - Jordy Benitez"`
    - `git push`
4. Either within the editor of your choice or within GitHub, create a pull request for your branch.
5. Get the approval of our QA Tester
6. Merge your changes into the "main" branch

## Release Notes - Code Milestone 1
TL;DR: We have setup our essential classes that are needed for the project, have implemented a database solution for our local storage needs, and have build the basic structure for front end.
1. Implemented the basic/essential classes needed to layout the structure for the project
2. Picked a framework that is going to scale to our needs.
3. Setup a database ORM (Entity Framework Core) that will both help us manage the database and inter-op with our code base.
4. Laid out the schema for our database
5. Setup the essential structure for the frontend of our program.
6. Created modularity with the frontend in order to facilitate any future needs that might show up in the future.
