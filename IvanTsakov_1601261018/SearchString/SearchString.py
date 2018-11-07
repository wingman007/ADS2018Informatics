

# I'll show you how to search in string in python.
import urllib2 

string = raw_input("Ask user for something:")
#you can modify this string below. This is just an example i wanted to show.
searc_string = (
    " I'm me and you are you, this is a string and we have to do a search for this."
)

if string in searc_string:
	print "\033[44;33m %s \033[m" % string
else:
	print "The string you searched for couldn't be found."

#you can insert any site you'd like i just hit google because it's the easiest. You will get all the css,html in text.
text = urllib2.urlopen("http://www.google.com").read(20000)
text = text.split("\n")
# uncommend the line below to see what's the result of text = urllib2.urlopen("http://www.google.com").read(20000)
# print text
# most likely this won't show anything good. but you can use txt files in urllib2
# for example -> urllib2.urlopen("http://www.myhost.com/SomeFile.txt")
if string in text:
	print "\033[44;33m %s \033[m" % string
else:
	print "The string you searched for couldn't be found."