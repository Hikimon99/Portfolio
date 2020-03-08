#----------------------------------------- 
# main3.py 
# creating first flask application 
#----------------------------------------- 
from flask import Flask, render_template 
app = Flask(__name__) 
books = [{'title': 'Software Engineering', 'id': '1'},  \
                 {'title':'Algorithm Design', 'id':'2'},            \
                 {'title':'Python', 'id':'3'}] 
				 
@app.route('/') 
def index(): return 
	render_template('hello.html') 
	
@app.route('/book2/') 
def book(): 
	return render_template('book2.html', books = books) 
	
if __name__ == "__main__": 
	app.run() 
# end of main3.py 