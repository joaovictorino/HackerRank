#!/bin/python3

import math
import os
import random
import re
import sys

def printLetters(value):
    count = 0
    charOdd = ''
    charEven = ''
    for letter in value:
        if(count%2 == 0):
            charEven += letter
        else:
            charOdd += letter
        count += 1

    print("{} {}".format(charEven, charOdd))

if __name__ == '__main__':
    values = []
    N = int(input())
    for x in range(0, N):
        values.append(input())

    for value in values:
        printLetters(value)