# C# Course Branch Plan (Visual Studio Friendly)

Based on the chapter timestamps in the provided video (`CBYHwZcbD-s`), this repository now has a recommended branch naming plan so you can work through each course section in Visual Studio.

## Suggested branch naming convention

Use:

- `course/csharp/01-intro`
- `course/csharp/02-vars-and-types`
- ...

## Course branches by chapter

1. `course/csharp/01-intro`
2. `course/csharp/02-vars-and-types`
3. `course/csharp/03-type-casting`
4. `course/csharp/04-user-input`
5. `course/csharp/05-math`
6. `course/csharp/06-random-numbers`
7. `course/csharp/07-hypotenuse-calculator`
8. `course/csharp/08-string-methods`
9. `course/csharp/09-if-statements`
10. `course/csharp/10-switches`
11. `course/csharp/11-logical-operators`
12. `course/csharp/12-while-loops`
13. `course/csharp/13-for-loops`
14. `course/csharp/14-nested-loops`
15. `course/csharp/15-arrays`
16. `course/csharp/16-foreach-loop`
17. `course/csharp/17-methods`
18. `course/csharp/18-return-keyword`
19. `course/csharp/19-method-overloading`
20. `course/csharp/20-params-keyword`
21. `course/csharp/21-exception-handling`
22. `course/csharp/22-conditional-operator`
23. `course/csharp/23-string-interpolation`
24. `course/csharp/24-multidimensional-arrays`
25. `course/csharp/25-classes`
26. `course/csharp/26-constructors`
27. `course/csharp/27-static`

## Creating branches in Visual Studio

1. Open the solution in Visual Studio.
2. Go to **Git Changes** (or **Git Repository** window).
3. Select your starting branch (for example `main` or `work`).
4. Create each `course/csharp/*` branch from the same base commit.
5. Use one branch per chapter to keep exercises isolated.

## CLI helper

Run this once to create all branches locally:

```bash
bash scripts/create_csharp_course_branches.sh
```

Then in Visual Studio, checkout the branch for the chapter you're studying and code there.
