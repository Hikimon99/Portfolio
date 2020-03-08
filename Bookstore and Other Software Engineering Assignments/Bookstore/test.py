import os
import sys
import unittest
from datetime import datetime

from models import app,db,Book,Author,Publisher
from create_db import db,Book,Author,Publisher

#one unit test should always check the max capacity of each thing
class DBTestCases(unittest.TestCase):
	def test_max_book(self):
		s = Book(isbn = str("a" * 30),id = str("a" * 20), title = str("a"*100),subtitle = str("a"*100), \
		date_pub = datetime(1000,5,5),author = str("a"*100),publisher = str("a"*100),description = None)
		
		db.session.add(s)
		db.session.commit()
		
		r = Book.query.get(str("a"*20))
		self.assertEqual(r.id,str("a"*20))

		db.session.query(Book).filter_by(id = 'aaaaaaaaaaaaaaaaaaaa').delete()
		db.session.commit()

	#make sure i can pass in a record with all nullable attribute = None
	def test_min_book(self):
		s = Book(id = "hi",title = "try",author = "1",publisher = "2")
		
		db.session.add(s)
		db.session.commit()
		
		r = Book.query.get("hi")
		self.assertEqual(r.id,"hi")
		self.assertEqual(r.isbn , None)
		
		db.session.query(Book).filter_by(id = "hi").delete()
		db.session.commit()	
		
	#just input a random record
	def test_randonIn_book(self):
		s = Book(isbn = "abcded123456",id = "asdfasd",title = "idbrules",subtitle = "whoot",date_pub = datetime(1223,4,4),\
		author = "victor",publisher = "idb",description = None)
		
		db.session.add(s)
		db.session.commit()
		
		r = Book.query.get("asdfasd")
		self.assertEqual(r.id,"asdfasd")
		self.assertEqual(r.isbn , "abcded123456")
		self.assertEqual(r.subtitle , "whoot")
		
		db.session.query(Book).filter_by(id = "asdfasd").delete()
		db.session.commit()
		
	def test_max_author(self):
		s = Author(name = str("a" * 100),birth = datetime(1223,4,4),nation = str("a"*100),alma_mater = str("a"*100),\
		education = str("a"*100), wiki_url = str("a"*100),img_url = str("a"*200))
		
		db.session.add(s)
		db.session.commit()
		
		r = Author.query.get(str("a"*100))
		self.assertEqual(r.nation,str("a"*100))
		self.assertEqual(r.alma_mater,str("a"*100))
		
		db.session.query(Author).filter_by(name = str("a"*100)).delete()
		db.session.commit()
		
	def test_min_author(self):
		s = Author(name = 'hi')
		
		db.session.add(s)
		db.session.commit()
		
		r = Author.query.get("hi")
		self.assertEqual(r.name,'hi')
		self.assertEqual(r.nation,None)
		
		db.session.query(Author).filter_by(name = "hi").delete()
		db.session.commit()
		
	def test_randonin_author(self):
		if db.session.query(Author).filter_by(name = "herro"):
			db.session.query(Author).filter_by(name = "herro").delete()
			db.session.commit()
	
		s = Author(name = "herro",birth = datetime(1233,4,4),nation = "yoyoyo",education = "lkajdlsfa\nlakjdsf")
		
		db.session.add(s)
		db.session.commit()
		
		r = Author.query.get("herro")
		self.assertEqual(r.nation,'yoyoyo')
		
		db.session.query(Author).filter_by(name = "herro").delete()
		db.session.commit()
		
	def test_max_publisher(self):
		s = Publisher(name = str("a" * 100), owner = str("a"*100), website = str("a"*100), description = str("a"*100),wiki_url = str("a"*100), img_url = str("a"*200))

		db.session.add(s)
		db.session.commit()

		r = Publisher.query.get(str("a"*100))
		self.assertEqual(r.owner, str("a"*100))
		self.assertEqual(r.description, str("a"*100))

		db.session.query(Publisher).filter_by(name = str("a"*100)).delete()
		db.session.commit()
		
	def test_min_publisher(self):
		s = Publisher(name = 'hi')
		
		db.session.add(s)
		db.session.commit()
		
		r = Publisher.query.get("hi")
		self.assertEqual(r.name,'hi')
		self.assertEqual(r.owner, None)
		
		db.session.query(Publisher).filter_by(name = "hi").delete()
		db.session.commit()
		
	def test_randIn_publisher(self):
		s = Publisher(name = "herro",owner = "victor",website = "hhtps://askdfj.com",wiki_url = "kajsldfalkdsf")
		
		db.session.add(s)
		db.session.commit()
		
		r = Publisher.query.get('herro')
		self.assertEqual(r.owner,"victor")
		self.assertEqual(r.name,'herro')
		
		db.session.query(Publisher).filter_by(name="herro").delete()
		db.session.commit()
		
if __name__ == '__main__':
    unittest.main()
