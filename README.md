# 20200922 Team Development/Managing Releases


Provide Answers for these Release Terms:
- diff
- branch
- tag
- code freeze
- release
- Release Notes
- Technical Service Bulletin (TSB)

### Terminal Commands
```
git status : check which branch you are on and if there are any changes (tracked or un-tracked)
git branch <branch> : creates a new branch (you have not switched to this branch yet)
git checkout <branch> : switch to another branch

git add -A : add all changes made on your branch
git commit -m "meaningful commit message" : commit changes made on your branch
git push origin <branch> : push changes to your branch

create pull request : github will prompt you to review your change and create a pull request
merge pull request : review any conflicts and merge
git pull origin master : pull any remote changes to your local repository

git tag : list tags
git tag -l "v1*" : search tags
git tag -a v1.0.0 -m "my version 1.4" : add a tag
git push origin <branch> --tags : push tags
git show v1.0.0 : show code from specific tag
```
### Classwork

*Divide the work among yourselves, create PRs often, and be prepared to speak to your process and final solution*

- Create a dot net mvc application with required packages
- Create and update a .gitignore file using `dotnet new gitignore` 
- Define a product model with properties product id, product name, product price, and product quantity
- Define a db context and add product model as db set
- Define a product controller with endpoints to view all products, render a form to create a new product, and add a product to the database
- Define views to display all products and to display a form for adding a new product
- Update landing page to route to view all products
- Update navigation bar with links to view all products and add a product

#### Manage Releases: Team members alternate between approving pull requests, tagging, and releasing
- CREATE branch CODE_FREEZE_1_09222020
- CREATE branch tag v01_00_00
- CREATE Release v1.00.00

- Fix at least 1 ticket/commit to branch
- CREATE branch tag v01_01_00
- CREATE Release v1.01.00

* Merge changes back to trunk *

Add views and actions to edit and delete products ON TRUNK (branch 'master')

- CREATE branch CODE_FREEZE_2_09222020
- CREATE branch tag v02.00.00
- CREATE Release v2.00.00

- Fix at least 1 ticket/commit to branch
- CREATE branch tag v02.01.00
- Fix at least 1 additional ticket/commit to branch
- CREATE branch tag v02.02.00
- CREATE Release v2.02.00

* Merge changes back to trunk *


