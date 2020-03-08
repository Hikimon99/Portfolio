from flask import Flask, render_template, request
from create_db import app,db,Book,Author,Publisher
import os


import subprocess

#cuz its all static, we should just initalize all the data will use with this import
#from data_static import book_data, pub_data, author_data

@app.route('/')
def index():
	return render_template('splash.html')
	
@app.route('/test/')
def test():
    p = subprocess.Popen(["coverage", "run", "--branch", "test.py"],
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
            stdin=subprocess.PIPE)
    out, err = p.communicate()
    output=err+out
    output = output.decode("utf-8") #convert from byte type to string type
	
    r = subprocess.Popen(["coverage","report","-m"],
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
            stdin=subprocess.PIPE)
    out, err = r.communicate()
    report=err+out
    report = report.decode("utf-8")
	
    return render_template('test.html', output = "<br />".join(output.split("\n")),report = "<br />".join(report.split("\n")))
	
@app.route('/about/')
def about():
	return render_template('about.html')

@app.route('/book/')
@app.route('/book/<num>')
def book(num = 1):
	bookData = Book.query.all()
	num = int(num) - 1
	#for future error page
	max_num = 11
	if num == 0:
		start = 0
	else:
		start = (num * 15) - 1
	if num < max_num and num >= 0:
		end = start + 15
		pipe = bookData[start:end]
		return render_template('book.html', data = pipe,num = num)
	elif num == max_num:
		pipe = bookData[start:]
		return render_template('book.html',data = pipe,num = num)
	else:
		return(render_template('splash.html'))
		
#<title> refers to a variable: with name title
#these variables are how we use the templates without having to create new pages for each record
#make sure to include title = title in the return statement, that's how we pass the title to the HTML
@app.route('/book_r/<title>')
def book_record(title):
	bookData = Book.query.filter_by(title=title).first()
	return render_template('book_rec.html',title = title,data = bookData)

@app.route('/publishers/')
@app.route('/publishers/<num>')
def publishers(num = 1):
	pubData = Publisher.query.all()
	num = int(num)
	if num == 0:
		start = 0
	else:
		start = (num * 15) - 1
	#for future error page
	max_num = 4	
	if num < max_num and num >= 0:
		end = start + 15
		pipe = pubData[start:end]
		return render_template('publishers.html', data = pipe,num = num)
	elif num == max_num:
		pipe = pubData[start:]
		return render_template('publishers.html',data = pipe,num = num)
	else:
		return(render_template('splash.html'))
	
@app.route('/publishers_r/<title>')
def publishers_record(title):
	pubData = Publisher.query.filter_by(name=title).first()
	book_w1 = Book.query.filter_by(publisher=title).all()
	aut_w1 = []
	for i in book_w1:
		aut_w1.append(Author.query.filter_by(name=i.author).all())
		#aut_w1 = Author.query.filter_by(name=i.author).all()
	temp = []
	for ele in aut_w1:
		if ele not in temp:
			temp.append(ele)
		
	return render_template('publishers_rec.html',title = title,data = pubData, book_w = book_w1, aut_w = temp)

@app.route('/authors/')
@app.route('/authors/<num>')
def authors(num = 1):
	authordata = Author.query.all()
	num = int(num)
	#for future error page
	max_num = 5
	if num == 0:
		start = 0
	else:
		start = (num * 15) - 1
	if num < max_num and num >= 0:
		end = start + 15
		pipe = authordata[start:end]
		return render_template('authors.html', data = pipe,num = num)
	elif num == max_num:
		pipe = authordata[start:]
		return render_template('authors.html',data = pipe,num = num)
	else:
		return(render_template('splash.html'))

@app.route('/authors_r/<title>')
def authors_record(title):
	authordata = Author.query.filter_by(name=title).first()
	book_w1 = Book.query.filter_by(author=title).all()
	pub_w1 = []
	for i in book_w1:
		pub_w1.append(Publisher.query.filter_by(name = i.publisher).all())
		#pub_w1 = Publisher.query.filter_by(name=i.publisher).all()
	temp = []
	for ele in pub_w1:
		if ele not in temp:
			temp.append(ele)
		
	return render_template('authors_rec.html', title = title,data = authordata, book_w = book_w1, pub_w = temp)

@app.route('/search/', methods=['GET', 'POST'])
def search():
        keyword = request.args.get("query")
               
        authors = Author.query.filter(Author.name.ilike('%'+keyword+'%'))
        publishers = Publisher.query.filter(Publisher.name.ilike('%'+keyword+'%'))
        books = Book.query.filter(Book.title.ilike('%'+keyword+'%'))

        i = authors.count()
        j = publishers.count()
        k = books.count()

        a = i + j + k

        return render_template('search.html', authors = authors, publishers = publishers, books = books, keyword = keyword, a = a)



if __name__ == "__main__":
	app.run()
