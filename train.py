from __future__ import absolute_import, division, print_function, unicode_literals
import tensorflow as tf
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Conv2D, Flatten, Dropout, MaxPooling2D, Activation
from tensorflow.keras.preprocessing.image import ImageDataGenerator

import csv
import os
import pandas as pd
import matplotlib.pyplot as plt
import sys

#PATH = 'C:/workspace/deep_learning/Kvasir_app/kvasir-dataset-v2'
PATH = sys.argv[1];

train_dir = os.path.join(PATH, 'train')
validation_dir = os.path.join(PATH, 'validation')

print(train_dir)
print(validation_dir)


train_dyed_lifted_polyps_dir = os.path.join(train_dir, 'dyed-lifted-polyps')  
train_dyed_resection_margins_dir = os.path.join(train_dir, 'dyed-resection-margins')  
train_esophagitis_dir = os.path.join(train_dir, 'esophagitis')  
train_normal_cecum_dir = os.path.join(train_dir, 'normal-cecum')  
train_normal_pylorus_dir = os.path.join(train_dir, 'normal-pylorus') 
train_normal_z_line_dir = os.path.join(train_dir, 'normal-z-line')  
train_polyps_dir = os.path.join(train_dir, 'polyps')  
train_ulcerative_colitis_dir = os.path.join(train_dir, 'ulcerative-colitis')  

validation_dyed_lifted_polyps_dir = os.path.join(validation_dir, 'dyed-lifted-polyps') 
validation_dyed_resection_margins_dir = os.path.join(validation_dir, 'dyed-resection-margins')
validation_esophagitis_dir = os.path.join(validation_dir, 'esophagitis') 
validation_normal_cecum_dir = os.path.join(validation_dir, 'normal-cecum')
validation_normal_pylorus_dir = os.path.join(validation_dir, 'normal-pylorus') 
validation_normal_z_line_dir = os.path.join(validation_dir, 'normal-z-line') 
validation_polyps_dir = os.path.join(validation_dir, 'polyps')  
validation_ulcerative_colitis_dir = os.path.join(validation_dir, 'ulcerative-colitis')


num_dyed_lifted_polyps_tr = len(os.listdir(train_dyed_lifted_polyps_dir))
num_dyed_resection_margins_tr = len(os.listdir(train_dyed_resection_margins_dir))
num_esophagitis_tr = len(os.listdir(train_esophagitis_dir))
num_normal_cecum_tr = len(os.listdir(train_normal_cecum_dir))
num_normal_pylorus_tr = len(os.listdir(train_normal_pylorus_dir))
num_normal_z_line_tr = len(os.listdir(train_normal_z_line_dir))
num_polyps_tr = len(os.listdir(train_polyps_dir))
num_ulcerative_colitis_tr = len(os.listdir(train_ulcerative_colitis_dir))

num_dyed_lifted_polyps_val = len(os.listdir(validation_dyed_lifted_polyps_dir))
num_dyed_resection_margins_val = len(os.listdir(validation_dyed_resection_margins_dir))
num_esophagitis_val = len(os.listdir(validation_esophagitis_dir))
num_normal_cecum_val = len(os.listdir(validation_normal_cecum_dir))
num_normal_pylorus_val = len(os.listdir(validation_normal_pylorus_dir))
num_normal_z_line_val = len(os.listdir(validation_normal_z_line_dir))
num_polyps_val = len(os.listdir(validation_polyps_dir))
num_ulcerative_colitis_val = len(os.listdir(validation_ulcerative_colitis_dir))

total_train = num_dyed_lifted_polyps_tr + num_dyed_resection_margins_tr + num_esophagitis_tr + num_normal_cecum_tr + num_normal_pylorus_tr + num_normal_z_line_tr + num_polyps_tr + num_ulcerative_colitis_tr
total_val = num_dyed_lifted_polyps_val + num_dyed_resection_margins_val + num_esophagitis_val + num_normal_cecum_val + num_normal_pylorus_val + num_normal_z_line_val + num_polyps_val + num_ulcerative_colitis_val

batch_size = 1
epochs = 1
IMG_HEIGHT = 576
IMG_WIDTH = 720

train_image_generator = ImageDataGenerator(rescale=1./255) # Generator for our training data
validation_image_generator = ImageDataGenerator(rescale=1./255) # Generator for our validation data

train_data_gen = train_image_generator.flow_from_directory(batch_size=batch_size,
                                                           directory=train_dir,
                                                           shuffle=True,
                                                           target_size=(IMG_HEIGHT, IMG_WIDTH),
                                                           class_mode='categorical')

val_data_gen = validation_image_generator.flow_from_directory(batch_size=batch_size,
                                                              directory=validation_dir,
                                                              target_size=(IMG_HEIGHT, IMG_WIDTH),
                                                              class_mode='categorical')

labels = train_data_gen.class_indices

df = pd.DataFrame(list(labels.items()), columns=['label', 'id'])

df.to_csv(sys.argv[2].replace('.h5', '.csv'), index=False)




sample_training_images, _ = next(train_data_gen)

# This function will plot images in the form of a grid with 1 row and 5 columns where images are placed in each column.
#def plotImages(images_arr):
#   fig, axes = plt.subplots(1, 5, figsize=(20,20))
#    axes = axes.flatten()
#   for img, ax in zip( images_arr, axes):
#       ax.imshow(img)
#       ax.axis('off')
#   plt.tight_layout()
#   plt.show()

#plotImages(sample_training_images[:5])

model = Sequential([
    Conv2D(16, 3, padding='same', activation='relu', input_shape=(IMG_HEIGHT, IMG_WIDTH ,3)),
    MaxPooling2D(),
    Conv2D(32, 3, padding='same', activation='relu'),
    MaxPooling2D(),
    Conv2D(64, 3, padding='same', activation='relu'),
    MaxPooling2D(),
    Flatten(),
    Dense(512, activation='relu'),
    Dense(8, activation='sigmoid'),
    Activation('softmax')
])

model.compile(optimizer='adam',
              loss='categorical_crossentropy',
              metrics=['accuracy'])

model.summary()

history = model.fit_generator(
    generator = train_data_gen,
    steps_per_epoch=total_train // batch_size,
    epochs=epochs,
    validation_data=val_data_gen,
    validation_steps=total_val // batch_size
)


checkpoint_path = "C:/workspace/deep_learning/Kvasir_app/model/checkpoint_3.ckpt"
checkpoint_dir = os.path.dirname(checkpoint_path)

# Create a callback that saves the model's weights
cp_callback = tf.keras.callbacks.ModelCheckpoint(filepath=checkpoint_path,
                                                 save_weights_only=True,
                                                 verbose=1)

model.save(sys.argv[2])

print(history.history.keys())

acc = history.history['accuracy']
val_acc = history.history['val_accuracy']

loss = history.history['loss']
val_loss = history.history['val_loss']

epochs_range = range(epochs)

plt.figure(figsize=(8, 8))
plt.subplot(1, 2, 1)
plt.plot(epochs_range, acc, label='Training Accuracy')
plt.plot(epochs_range, val_acc, label='Validation Accuracy')
plt.legend(loc='lower right')
plt.title('Training and Validation Accuracy')

plt.subplot(1, 2, 2)
plt.plot(epochs_range, loss, label='Training Loss')
plt.plot(epochs_range, val_loss, label='Validation Loss')
plt.legend(loc='upper right')
plt.title('Training and Validation Loss')
plt.show()