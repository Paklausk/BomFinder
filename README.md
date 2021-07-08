# BomFinder
[![GitHub](https://img.shields.io/github/license/Paklausk/BomFinder?style=for-the-badge)](https://github.com/Paklausk/BomFinder/blob/master/LICENSE)
[![GitHub last commit](https://img.shields.io/github/last-commit/Paklausk/BomFinder.svg?style=for-the-badge)]()

Prints out a list of files containing Byte Order Mark(BOM) UTF-8 signature in current directory and subdirectories.

### Why BomFinder is useful?

Some applications insert 3 byte BOM signature to indicate that the file is Unicode. This may ruin file comparison when text on both sides is the same, but it still would be treated as different, or visual text output which would start with `ï»¿` characters. BomFinder helps to find all these problematic files.
