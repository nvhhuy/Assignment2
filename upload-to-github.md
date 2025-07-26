# Instructions to Upload to GitHub

## Step 1: Create a New Repository on GitHub

1. Go to https://github.com
2. Click the "+" button in the top right corner
3. Select "New repository"
4. Repository name: `assignment-2`
5. Description: `Hotel Management System by Nguyen Vo Hoang Huy - PRN212 Assignment 2`
6. Make it **Public** or **Private** (your choice)
7. **DO NOT** initialize with README, .gitignore, or license (we already have these)
8. Click "Create repository"

## Step 2: Connect Your Local Repository to GitHub

Run these commands in your project directory:

```bash
# Add the remote repository (replace YOUR_USERNAME with your GitHub username)
git remote add origin https://github.com/YOUR_USERNAME/assignment-2.git

# Push your code to GitHub
git branch -M main
git push -u origin main
```

## Step 3: Verify Upload

1. Go to your GitHub repository URL
2. You should see all the files including:
   - README.md
   - NguyenVoHoangHuy_PRN212_A02.sln
   - All project folders (BusinessObjects, DataAccessLayer, etc.)
   - .gitignore file

## Project Structure After Upload

```
assignment-2/
├── README.md                           # Project documentation
├── .gitignore                          # Git ignore rules
├── NguyenVoHoangHuy_PRN212_A02.sln    # Solution file
├── appsettings.json                    # Configuration
├── BusinessObjects/                    # Data models
├── DataAccessLayer/                    # Database access
├── Repositories/                       # Repository pattern
├── Services/                           # Business logic
└── NguyenVoHoangHuyWPF/              # WPF application
```

## Important Notes

- The project has been renamed from "HuynhPhucTan" to "NguyenVoHoangHuy"
- All references have been updated in the solution file
- The README.md contains your name and project information
- The .gitignore file excludes build artifacts and temporary files
- The repository is ready for GitHub upload

## Troubleshooting

If you get any errors:

1. Make sure you have Git installed
2. Ensure you're logged into GitHub in your terminal
3. Check that the repository URL is correct
4. Try running `git status` to see the current state
