import json
from datetime import datetime
from models import app, db, Book, Author, Publisher

def load_json(filename):
	with open(filename) as file:
		jsn = json.load(file)
		file.close()

	return jsn

def create_books():
	book = load_json('books.json')
	for oneBook in book:
		#print(oneBook['title'])
		if Book.query.get(oneBook['google_id']) is None:
			isbn = oneBook.get('isbn')
			title = oneBook.get('title')
			try:
				sub = oneBook['subtitle']
			except KeyError:
				sub = None
			id = oneBook.get('google_id')
			date_pub = oneBook.get('publication_date')
			if date_pub:
				try:
					date_pub = datetime.date(datetime.strptime(oneBook.get('publication_date'),"%Y-%m-%d"))
				except:
					date_pub = None
			image_url = oneBook['image_url'] 	
			description = oneBook.get('description')
			#we cant import a list into our db
			for pub in oneBook['publishers']:
				publisher = pub['name']
				create_publishers(pub)
			#we cant import a list into our db
			for aut in oneBook['authors']:
				author = aut['name']
				create_authors(aut)

			newBook = Book(isbn = isbn,id = id,title = title,subtitle = sub,date_pub = date_pub,author = author,publisher = publisher,description = description,img_url = image_url)
		
			db.session.add(newBook)
			db.session.commit()

def create_publishers(pub):
	if Publisher.query.get(pub['name']) is None:
		name = pub['name']
		owner = pub.get('owner')
		description = pub.get('description')
		wikipedia_url = pub.get('wikipedia_url')
		image_url = pub.get('image_url')
		website = pub.get('website')
		
		newPublisher = Publisher(name = name,owner = owner,website = website,description = description,wiki_url = wikipedia_url,img_url = image_url)
		db.session.add(newPublisher)
		db.session.commit()

def create_authors(aut):
	if Author.query.get(aut['name']) is None:
		name = aut.get('name')
		birth = aut.get('born')
		if birth:
			try:
				birth = datetime.date(datetime.strptime(birth,"%Y-%m-%d"))
			except:
				birth = None
		education = aut.get('education')
		if len(str(education).split("\n")) != 1:
			education = education[0]
		nationality = aut.get('nationality')
		alma_mater = aut.get('alma_mater')
		description = aut.get('description')
		wikipedia_url = aut.get('wikipedia_url')
		image_url = aut.get('image_url')
		
		newAuthor = Author(name = name,birth = birth,nation = nationality, alma_mater = alma_mater,education = education, wiki_url = wikipedia_url,img_url = image_url, description = description)
		db.session.add(newAuthor)
		db.session.commit()

create_books()
