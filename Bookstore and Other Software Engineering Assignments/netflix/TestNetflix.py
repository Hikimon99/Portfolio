#!/usr/bin/env python3

# -------
# imports
# -------
from Netflix import netflix_eval
from unittest import main, TestCase
from math import sqrt
from io import StringIO
from numpy import sqrt, square, mean, subtract

# -----------
# TestNetflix
# -----------

class TestNetflix (TestCase):

    # ----
    # eval
    # ----

    def test_eval_1(self):
        r = StringIO("10040:\n2417853\n1207062\n2487973\n")
        w = StringIO()
        netflix_eval(r, w)
        self.assertEqual(
            w.getvalue(), "10040:\n3.4\n3.4\n3.7\n0.89\n")

    def test_rmse_value(self):
        r = StringIO("10040:\n2417853\n1207062\n2487973\n")
        w = StringIO()
        netflix_eval(r,w)
        rmse = w.getvalue()
        rmse = rmse.split()
        assert float(rmse[-1]) < 1.0

    def test_movie_id(self):
        r = StringIO("10040:\n2417853\n1207062\n2487973\n")
        w = StringIO()
        netflix_eval(r,w)
        movie = w.getvalue()
        movie = movie.split()
        assert movie[0] == "10040:"

# ----
# main
# ----			
if __name__ == '__main__':
    main()

""" #pragma: no cover
% coverage3 run --branch TestNetflix.py >  TestNetflix.out 2>&1



% coverage3 report -m                   >> TestNetflix.out



% cat TestNetflix.out
.
----------------------------------------------------------------------
Ran 1 test in 0.000s

OK
Name             Stmts   Miss Branch BrPart  Cover   Missing
------------------------------------------------------------
Netflix.py          27      0      4      0   100%
TestNetflix.py      13      0      0      0   100%
------------------------------------------------------------
TOTAL               40      0      4      0   100%

"""
