# TV Show NFO Editor

## Purpose

TV Show NFO Editor is a simple program designed to create and edit XBMC-compatible
NFO files for TV Shows. The original impetus was to support the "extras" that come
on TV series DVD sets.

The current policy of TheTVDB.com is to disallow adding DVD-based extras, which makes
it difficult to impossible to have the XBMC scrapers automatically pick up information
on these additional videos.

In order to prevent an overlap between TheTVDB.com "approved" extras (which are defined 
as being part of Season 0 or "Specials"), I wanted to put these extras within the season
folder of the TV shows themselves. My preference was to put them in a subfolder titled
"Extras" and use episode numbers beginning with 100, as I couldn't think of a program that
had more than 99 episodes per season.

TV Show NFO Editor helps to automate the process. It understands the most common folder 
structure (TV Show root\Series Name\Season #) plus an optional "Extras" subfolder under
each season. It generates "episodedetails" XML within a .NFO file by scraping information
off a screen designed for fast data entry. It can also parse and edit existing .NFO files,
generate filenames for the media files themselves (so it can be used during the ripping
process), create new folders and accept and generate clipboard events for easy copy/paste
operations.

## Release History

### 1.0.0 

First release of code under Apache License 2.0.