from flask import Flask 
from flask_sqlalchemy import SQLAlchemy 
import os 

app = Flask(__name__) 
app.config['SQLALCHEMY_DATABASE_URI'] =  os.environ.get("DB_STRING",'postgres://postgres:idb_ivhad@localhost:5432/book_idb') 
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True # to suppress a warning message 
db = SQLAlchemy(app) 

written = db.Table('written',
	db.Column('book', db.String, db.ForeignKey('book.id')),
	db.Column('author', db.String, db.ForeignKey('author.name')))
	
publishment = db.Table('publishment',
	db.Column('publisher', db.String, db.ForeignKey('publisher.name')),
	db.Column('book', db.String, db.ForeignKey('book.id')))
	
publish = db.Table('publish',
	db.Column('author', db.String, db.ForeignKey('author.name')),
	db.Column('publisher', db.String, db.ForeignKey('publisher.name')))


class Book(db.Model): 
	__tablename__ = 'book' 
	
	isbn = db.Column(db.String(30))
	id = db.Column(db.String(20),unique = True,primary_key = True)
	img_url = db.Column(db.String(405))
	title = db.Column(db.String(100),nullable = False)
	subtitle = db.Column(db.String(100))
	date_pub = db.Column(db.Date)
	author = db.Column(db.String(100),nullable = False)
	publisher = db.Column(db.String(100),nullable = False)
	description = db.Column(db.String)
	writer = db.relationship('Author', secondary= written, backref= db.backref('wrote', lazy = 'dynamic'))
	
class Author(db.Model):
	__tablename__ = 'author'
	
	name = db.Column(db.String(100),primary_key = True)
	birth = db.Column(db.Date)
	nation = db.Column(db.String(100))
	alma_mater = db.Column(db.String(100))
	education = db.Column(db.String(100))
	description = db.Column(db.String)
	wiki_url = db.Column(db.String(100))
	img_url = db.Column(db.String(405))
	publish = db.relationship('Publisher', secondary= publish, backref= db.backref('helpedPub', lazy = 'dynamic'))
	
	
class Publisher(db.Model):
	__tablename__ = 'publisher'
	
	name = db.Column(db.String(100),primary_key = True)
	owner = db.Column(db.String(100))
	website = db.Column(db.String(100))
	description = db.Column(db.String)
	wiki_url = db.Column(db.String(100))
	img_url = db.Column(db.String(200))
	bookPub = db.relationship('Book', secondary= publishment, backref= db.backref('listPub', lazy = 'dynamic'))
	
db.create_all() 
