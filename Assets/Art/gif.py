import os, PIL, string, numpy
from PIL import Image, image2gif

filearray = ['walk0.png','walk1.png','walk2.png','walk1.png','walk3.png','walk4.png','walk5.png','walk4.png']

imagearray = []
newarray = []


for f in filearray:
    image = Image.open(f)
    w, h = 126,238
    image = image.resize((w,h))
    print(image.size)
    image.save(f)







# def makeGif():
#     w, h = imagearray[0].size
#     for newfile in imagearray:
#         newarray.append(newfile.resize((w * 7, h * 7)))
#
#     gif = image2gif.writeGif('walk.gif', newarray, duration=.13, dither=True, repeat=True, subRectangles=False)
#
# makeGif()
