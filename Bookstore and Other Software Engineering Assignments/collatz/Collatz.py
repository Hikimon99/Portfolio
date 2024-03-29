#!/usr/bin/env python3

# ---------------------------
# projects/collatz/Collatz.py
# Copyright (C) 2016
# Glenn P. Downing
# ---------------------------

# ------------
# collatz_read
# ------------


def collatz_read(s):
    """
    read two ints
    s a string
    return a list of two ints, representing the beginning and end of a range, [i, j]
    This is needed because we need to read the intervals and this function delivers those two to us.
    """
    a = s.split()
    return [int(a[0]), int(a[1])]

# ------------
# collatz_eval
# ------------


def collatz_eval(i, j):
    """
    i the beginning of the range, inclusive
    j the end       of the range, inclusive
    return the max cycle length of the range [i, j]

    This function is needed in order to actually find the max cycle length of a particular interval.
    This function uses the function cycle_length multiple times, storing the max length of numbers in the intervals
    """
    cache_a = [179, 182, 217, 238, 215, 236, 262, 252, 247, 260, 268, 250, 263, 276, 271, 271, 266, 279, 261, 274, 256, 269, 269, 282, 264, 264, 308, 259, 259, 272, 272, 285, 267, 267, 311, 324, 249, 306, 244, 306, 288, 257, 288, 270, 270, 314, 283, 314, 296, 296, 278, 309, 340, 322, 260, 260, 322, 304, 273, 304, 335, 317, 286, 330, 299, 268, 268, 312, 312, 299, 312, 325, 263, 294, 325, 307, 307, 351, 338, 307, 320, 320, 320, 289, 320, 302, 302, 333, 333, 315, 315, 333, 315, 284, 315, 328, 297, 297, 284, 328, 341, 310, 310, 248, 310, 341, 354, 292, 279, 310, 292, 323, 323, 292, 305, 349, 305, 305, 336, 305, 318, 336, 318, 331, 287, 318, 331, 287, 331, 344, 331, 300, 331, 313, 300, 344, 313, 331, 313, 313, 344, 326, 375, 282, 326, 295, 357, 295, 326, 326, 370, 295, 308, 308, 352, 308, 383, 339, 321, 352, 370, 290, 339, 321, 334, 321, 352, 321, 321, 334, 290, 334, 303, 347, 334, 272, 334, 334, 347, 303, 365, 316, 334, 254, 316, 329, 347, 329, 316, 360, 329, 329, 347, 329, 342, 360, 298, 285, 329, 329, 342, 311, 342, 311, 311, 355, 373, 311, 311, 311, 342, 355, 355, 373, 293, 280, 386, 324, 324, 355, 324, 355, 324, 324, 324, 368, 368, 306, 355, 306, 443, 350, 337, 368, 381, 306, 337, 350, 306, 350, 368, 275, 319, 337, 275, 319, 332, 350, 288, 350, 332, 319, 319, 332, 363, 288, 332, 345, 301, 345, 332, 332, 301, 407, 332, 332, 314, 345, 270, 345, 407, 283, 314, 358, 332, 345, 314, 389, 345, 314, 345, 358, 314, 358, 358, 376, 314, 327, 389, 345, 327, 327, 340, 358, 296, 358, 327, 327, 371, 327, 371, 296, 340, 340, 340, 265, 309, 309, 371, 340, 371, 309, 384, 340, 278, 340, 353, 309, 353, 322, 371, 353, 309, 322, 384, 340, 247, 322, 291, 353, 322, 291, 353, 335, 322, 322, 366, 366, 335, 366, 304, 335, 353, 335, 304, 441, 348, 322, 335, 366, 304, 379, 335, 304, 348, 379, 348, 304, 379, 348, 410, 348, 361, 317, 317, 361, 348, 286, 317, 361, 392, 348, 317, 348, 330, 361, 423, 361, 330, 361, 379, 374, 361, 330, 330, 348, 330, 299, 330, 436, 361, 330, 299, 361, 405, 312, 330, 330, 374, 299, 374, 387, 268, 343, 343, 405, 361, 268, 312, 312, 449, 330, 343, 374, 374, 312, 387, 343, 343, 281, 343, 325, 356, 418, 356, 356, 356, 374, 294, 281, 312, 343, 387, 343, 356, 281, 325, 387, 400, 356, 325, 294, 356, 338, 325, 338, 325, 325, 369, 369, 387, 307, 294, 369, 338, 338, 356, 338, 307, 307, 307, 444, 369, 325, 338, 369, 369, 413, 382, 338, 307, 276, 338, 307, 382, 320, 307, 382, 351, 351, 413, 382, 351, 307, 320, 338, 382, 382, 382, 351, 320, 320, 426, 395, 351, 320, 320, 289, 351, 395,
               364, 320, 426, 320, 364, 364, 382, 364, 377, 364, 333, 470, 333, 351, 364, 395, 302, 333, 439, 364, 333, 364, 333, 302, 364, 408, 408, 377, 377, 333, 346, 346, 377, 377, 346, 302, 333, 377, 346, 346, 408, 364, 346, 359, 315, 346, 452, 377, 333, 315, 346, 377, 315, 346, 421, 390, 346, 315, 315, 284, 359, 328, 359, 328, 421, 328, 359, 359, 359, 359, 377, 359, 372, 359, 328, 346, 390, 390, 346, 359, 266, 328, 328, 434, 372, 359, 359, 328, 315, 297, 359, 403, 328, 328, 328, 328, 372, 372, 341, 372, 372, 403, 297, 297, 372, 341, 328, 341, 403, 359, 341, 354, 310, 310, 310, 447, 372, 372, 310, 341, 372, 372, 310, 354, 385, 354, 509, 341, 279, 279, 341, 310, 385, 354, 310, 416, 310, 354, 354, 354, 416, 372, 416, 279, 279, 310, 323, 341, 323, 385, 341, 336, 354, 385, 323, 385, 429, 354, 398, 354, 323, 323, 292, 292, 367, 442, 323, 367, 323, 336, 323, 323, 367, 336, 367, 385, 336, 336, 380, 367, 336, 336, 305, 380, 336, 354, 398, 380, 292, 336, 336, 442, 323, 367, 367, 336, 336, 318, 367, 367, 367, 411, 380, 349, 504, 380, 305, 349, 349, 336, 380, 380, 411, 380, 305, 305, 380, 349, 336, 349, 411, 367, 411, 349, 362, 305, 349, 318, 362, 318, 380, 336, 380, 349, 349, 424, 318, 380, 424, 424, 393, 318, 349, 318, 318, 349, 287, 362, 318, 393, 362, 331, 318, 424, 318, 362, 362, 331, 362, 362, 380, 362, 331, 375, 362, 331, 331, 468, 331, 393, 349, 344, 393, 362, 331, 437, 331, 393, 437, 362, 344, 362, 331, 331, 313, 375, 300, 362, 406, 406, 375, 344, 437, 375, 331, 331, 468, 344, 300, 375, 375, 406, 388, 300, 331, 375, 344, 406, 331, 344, 406, 287, 362, 375, 313, 357, 344, 344, 450, 357, 450, 375, 344, 375, 326, 344, 313, 419, 313, 375, 344, 419, 388, 357, 344, 313, 344, 525, 344, 388, 357, 313, 388, 331, 357, 401, 313, 419, 313, 357, 357, 357, 326, 357, 419, 388, 375, 357, 370, 313, 357, 326, 326, 344, 326, 388, 326, 344, 357, 388, 326, 432, 326, 326, 388, 432, 370, 401, 326, 357, 326, 326, 313, 370, 295, 370, 445, 401, 295, 370, 339, 326, 295, 326, 370, 326, 370, 339, 370, 295, 401, 401, 383, 295, 383, 295, 445, 326, 370, 326, 476, 383, 401, 357, 370, 339, 339, 383, 339, 432, 339, 339, 445, 308, 370, 339, 370, 476, 383, 339, 370, 308, 370, 370, 414, 414, 383, 352, 445, 507, 383, 339, 339, 352, 383, 352, 383, 383, 383, 352, 414, 383, 414, 414, 383, 339, 352, 352, 321, 352, 414, 352, 383, 414, 352, 321, 365, 308, 321, 352, 458, 352, 321, 383, 383, 339, 383, 334, 383, 334, 427, 321, 383, 383, 352, 427, 352, 396, 321, 352, 321, 321, 352, 290, 365, 365, 365, 440, 396, 396, 259]
    if(i > j):
        i, j = j, i
    # assert i >0
    store = []
    start = int(i / 1000)
    end = int(j / 1000)
    # assert end < 1001
    # if interval is within a certain range under 2000 ie. 1044 - 2799
    if (start == end) or (start + 1 == end):
        while i < j+1:
            store.append(cycle_length(i))
            i += 1
        return max(store)
    # Interval over 2000 and able to use cache_a
    upper_bound = round(i + 500, -3)
    lower_bound = round(j - 500, -3)
    while start < end - 1:
        store.append(cache_a[start + 1])
        start += 1
    while i != upper_bound:
        store.append(cycle_length(i))
        i += 1
    while lower_bound < j + 1:
        store.append(cycle_length(lower_bound))
        lower_bound += 1
    return max(store)

# Used to assist collatz_eval in finding the cycle length


def cycle_length(n):
    # assert n > 0
    c = 1
    while n > 1:
        if (n % 2) == 0:
            n = (n >> 1)
        else:
            n = (n << 1) + n + 1
        c += 1
    return c

# -------------
# collatz_print
# -------------


def collatz_print(w, i, j, v):
    """
    print three ints
    w a writer
    i the beginning of the range, inclusive
    j the end       of the range, inclusive
    v the max cycle length
    Prints interval and max cycle length of the interval
    """
    w.write(str(i) + " " + str(j) + " " + str(v) + "\n")

# -------------
# collatz_solve
# -------------


def collatz_solve(r, w):
    """
    r a reader
    w a writer
    Useful because this is the only function required to call to use fulfil the purpose of this assignment
    """
    for s in r:
        i, j = collatz_read(s)
        v = collatz_eval(i, j)
        collatz_print(w, i, j, v)
