For when you really need to brush up on this stuff...

master - default name for any branch on Git (points to the latest commit)

BRANCHING FLOW & WHAT'S WHAT

1. Creating a new branch:
$ git branch [branch name]
--> creates a new pointer to the same commit you're currently on
--> this also creates a HEAD pointer (= a pointer to show you which branch you're on - in this case, it's still 'master', because...)
--> 'git branch' DOES NOT checkout that newly created branch!

USEFUL:
$ git log --oneline --decorate
--> shows you where the branch pointers are pointing

2. Switching branches
$ git checkout [branch name] / OR: git switch [branch name]
--> HEAD starts pointing to this branch

Once you make a commit on this branch - 'master' still points to the original commit/the last commit before 'git checkout'

$ git log --oneline --decorate 
--> will show you where your branch pointers are and where your branches diverged

--------------------------------------------------------------
NEW FILE FLOW - top-down (i.e. from local IDE to remote repo)
1. Create the file and modify it as needed.
-> Make sure there's no spaces in the file name!
2. git add [file name] --> adds the file to index/stage
3. git commit (-m "your message") --> adds your file to HEAD
4. git push origin main --> pushes your file to your repo (Git changed the name 'master' to 'main')