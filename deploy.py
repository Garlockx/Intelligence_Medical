import tensorflow as tf
from tensorflow import keras
from keras.preprocessing import image
from tensorflow.keras.preprocessing.image import ImageDataGenerator

import csv
import os
import numpy as np
import pandas as pd
import sys
import matplotlib.pyplot as plt


IMG_HEIGHT = 720
IMG_WIDTH = 576

model = keras.models.load_model(sys.argv[2])
classCsv = sys.argv[2].replace('.h5', '.csv')

test_image = image.load_img(sys.argv[1])
test_image = image.img_to_array(test_image)
test_image = np.expand_dims(test_image, axis = 0) 

proba = model.predict_proba(test_image, batch_size = 1)
class_predict = model.predict_classes(test_image, batch_size = 1)

print("Probabilities : ")
print(proba)
print("Class Predict : ")
print(class_predict[0])

labels = pd.read_csv(
        classCsv,
        dtype=object,
        keep_default_na=False,
        na_values=[]).values

graphLabels = []

for label in labels:
	graphLabels.append(label[0])
	if label[1] == str(class_predict[0]) :
		print("Label of class predict : ")
		print(label[0])

fig1, ax1 = plt.subplots()
ax1.pie(proba, labels=graphLabels, autopct='%1.1f%%', shadow=True, startangle=90)
ax1.axis('equal')

plt.show()