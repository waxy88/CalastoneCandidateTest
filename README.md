# CalastoneCandidateTest
A filtering program for the interview process with Calastone.
Three filters were specifed and a file to filter was supplied.
The first filter looks for the middle of a word and if the middle is a vowel (or vowels) it should be filtered out.
The second filter was to remove any words with length less than 3 characters.
The final filter was to remove any words that contained a specific letter, in this case 't'

Each filter utilises the IFilter interface which specifies a Filter method, which takes a word string as input and returns either an empty string
(if the word has been filtered or the word if it passes. There is an AllFilters class which contains an Apply entry point method, to apply all declared
filters on a list of strings passed to it. It returns a list of strings, which have been cleaned by the filters.

I decided to split the file string in the Main program and use regex, so that I could use a number of delimiters, as I noticed that note all words were
cleanly delimited by space (obviously), so wanted to use punctuation as well as space to delimit the words.
