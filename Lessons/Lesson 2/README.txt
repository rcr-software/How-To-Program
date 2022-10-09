Lesson 2:

This lesson goes over how to use terminal a bit and how to work with git. It will also go over commenting your commits and your code

To learn how to run code in terminal got to ln 29
to learn about git commands, go to ln 33
to follow a step by step of how to setup your git and push go to ln 52

Prompt:

Setup your local git repo in a folder.
create a new branch (branch names should be simple yet informative), I would suggest Lesson 1 solution FL (with FL being first initial last initial), 
add your program from lesson 1 into the solutions folder, push it, and make a PR
create a new branch for lesson 2, add the same program to the lesson 2 solutions folder
comment your code:
	Code commenting is important so other people can actually read your code without going line by line.
	Every line does not need to be explained. typically, you just label a scope or unique block of code.
	something like a switch, at the top you say what you are switching.
	along with this you would also put a comment by a large repetitive block like a bunch of similar variables.
	Lastly any code that is not obvious what it does. if a line or part of a function is not commonly use just put a small comment explaining it.
	ex.
		(torque & 1) == 1 //checks to see if first bit of this int is a 1
	This line of code uses & which is a very uncommon operation so I would explain it so some people who may have not ever used it can understand
commit you changes, push your branch, and make a second PR for that branch.
change you local branch to main, then after both PRs are approved, pull main then delete old branches.



Terminal c#:
dotnet new console						//creates a console project in given dir
dotnet run <main.cs>						//runs the main file

How to git:
git config --global user.name "FIRST LAST"			//adds you name to git
git config --global user.email "email"				//ads an email for git
git add <filename.ext || .>					//adds new files to git or everything
git status							//shows files to be added to git or changed (staged changes)
git commit -m "YOUR COMMIT MESSAGE HERE"			//saves all changes
git checkout -b <branch name here>				//creates a new branch.
git checkout <branch name here>					//switches between branches
git merge <branch name here>					//merges inputted branch INTO WORKING branch.
git remote add origin <link>					//adds the GitHub repo to the folder
git push origin <branch name>					//pushes branch to GitHub
git pull origin <branch name>					//pulls from git to branch
git branch -d <branch name>					//deletes branch
git restore --staged <filename.ext || .>			//unsaves staged changes

//if a window appears asking you to write a comment, write a comment for the merge or commit and then do this:
press <esc> type<:wq>  press<enter>				//how to exit the comment window
//if you are trying to type and don’t see anything appear press<insert>

Oder of operations:

	First time setup:
	
		git config --global user.name "FIRST LAST"	//adds you name to git
		git config --global user.email "email"		//ads an email for git
		git remote add origin <link>			//adds the GitHub repo to the folder

	git pull origin master					//this will update you master branch to be the same as GitHub
	git checkout -b <branch name>				//create a new branch to start working in.

		start working on your project/feature/change

	git pull origin <branch name>				//updates your branch again to make sure there is no merge issues

		Fix any merge issues if any

	git add .						//adds all files you added or changed
	git commit -m "you commit message"			//actually saves all your chages
	git push origin <branch name>				//pushes your branch to the repo waiting for it to be reviewed after u make a PR
	git checkout master					//back to master because you are done with your branch

		Go to GitHub and make a PR (pull request) to get your code merged to main
		once your branch has been reviewed the person who reviewed it will message you and let you know if it was approved or denied
		if it was denied, go read why fix it, re push it

	git branch -d <branch name>				//after your PR is approved you don’t need to store that branch locally so u can delete it
