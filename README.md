# checkHaveIBeenPwned
A desktop interface to access Troy Hunt's haveibeenpwned.com site - because I was weary of hand typing addresses, and I don't know Python (I did write a Powershell script, but it's rather clumsy)

Pretty simple little util. Mostly for my own use; Still need to deal with the JSON properly if I was going to make this 
more user-friendly. 

Version 1.2 adds a 'Check All' button to iterate through the list, and add the pwned addresses to a list on the right.
It sleeps for 1.7 seconds between items (Troy's site throttles at 1.5 seconds).

I should put in an a elapsed-time check to make sure to avoid the 429s when clicking manually. But for me, at this time, it's fine
