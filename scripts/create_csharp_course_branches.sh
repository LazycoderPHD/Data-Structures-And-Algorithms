#!/usr/bin/env bash
set -euo pipefail

BASE_BRANCH="${1:-$(git branch --show-current)}"

branches=(
  "course/csharp/01-intro"
  "course/csharp/02-vars-and-types"
  "course/csharp/03-type-casting"
  "course/csharp/04-user-input"
  "course/csharp/05-math"
  "course/csharp/06-random-numbers"
  "course/csharp/07-hypotenuse-calculator"
  "course/csharp/08-string-methods"
  "course/csharp/09-if-statements"
  "course/csharp/10-switches"
  "course/csharp/11-logical-operators"
  "course/csharp/12-while-loops"
  "course/csharp/13-for-loops"
  "course/csharp/14-nested-loops"
  "course/csharp/15-arrays"
  "course/csharp/16-foreach-loop"
  "course/csharp/17-methods"
  "course/csharp/18-return-keyword"
  "course/csharp/19-method-overloading"
  "course/csharp/20-params-keyword"
  "course/csharp/21-exception-handling"
  "course/csharp/22-conditional-operator"
  "course/csharp/23-string-interpolation"
  "course/csharp/24-multidimensional-arrays"
  "course/csharp/25-classes"
  "course/csharp/26-constructors"
  "course/csharp/27-static"
)

git rev-parse --verify "$BASE_BRANCH" >/dev/null 2>&1 || {
  echo "Base branch '$BASE_BRANCH' not found." >&2
  exit 1
}

base_commit="$(git rev-parse "$BASE_BRANCH")"

for branch in "${branches[@]}"; do
  if git show-ref --verify --quiet "refs/heads/$branch"; then
    echo "exists: $branch"
  else
    git branch "$branch" "$base_commit"
    echo "created: $branch"
  fi
done

echo "Done. Created any missing C# course branches from '$BASE_BRANCH'."
