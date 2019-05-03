# Contributing
## Commits
### Use [Conventional Commits](https://www.conventionalcommits.org)
Prefix your commit messages with [type](https://github.com/commitizen/conventional-commit-types/blob/master/index.json) (_ie_ `feat`, `fix` or `docs`). Examples:
- `feat: add option to backup config`
- `perf: optimize classifying tags`
- `fix: resolve #3`

### Use [Verified Signing](https://help.github.com/en/articles/signing-commits)
Sign your commits. Examples:
- Use `git commit -S` instead of single `git commit` every commit.
- Use `git config --global user.signingkey true` once (with [`user.signingkey`](https://help.github.com/en/articles/telling-git-about-your-signing-key) set).

### Use [Developer Certificate of Origin](https://developercertificate.org/)
Sign your commits. Examples:
- Use `git commit -s` instead of single `git commit` every commit.
- Use [`prepare-commit-msg`](https://stackoverflow.com/a/46536244/1180790) hook to add `Signed-off-by` line.
- Use `git config --global format.signoff true` once.
