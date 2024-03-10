### Official Python Implementation
This work was conducted by Soeun Han, Wonjun Park, Kyumin Jeong, Taehoon Hong, and Choongwan Koo (Corrensponding Author) | Paper
Construction Engineering & Management Lab, Incheon National University.

### Cite This:
Han, S., Park, W., Jeong, K., Hong, T., and Koo, C. (2024). “Utilizing synthetic images to enhance the automated recognition of small-sized construction tools”, Automation in Construction (under review). <br><br>

# Utilizing synthetic images to enhance the automated recognition of small-sized construction tools

### Abstract
Previous studies on vision-based classifiers often overlooked the need for detecting small-sized construction tools. Considering the substantial variations in these tools' size and shape, it is essential to train models using synthetic images that encompass diverse angles and distances. This study aimed to improve the performance of classifiers for small-sized construction tools by leveraging synthetic data. Three classifiers were proposed using YOLOv8 algorithm, varying in data composition: (i) 'Real-4000': 4,000 authentic images; (ii) 'Hybrid-4000': 2,000 authentic and 2,000 synthetic images; (iii) 'Hybrid-8000': 4,000 authentic and 4,000 synthetic images. To assess practical applicability, a test dataset of 144 samples for each type was collected directly from construction sites. Results revealed that the 'Hybrid-8000' model, utilizing synthetic images, excelled at 94.8% of mAP_0.5. This represented a significant 15.2% improvement, affirming its practical applicability. These classifiers hold promise for enhancing safety and advancing real-time automation and robotics in construction. <br><br>

### Keywords
Small-sized construction tools; Object detection and classification; Synthetic images; Practical applicability; Construction site <br><br>

### Framework and Dataset
Figure 1. Research framework

![Figure1](https://github.com/SenseableSpace/Utilizing-synthetic-images-to-enhance-the-automated-recognition-of-small-sized-construction-tools/assets/162809473/12262482-c487-496e-970d-bd673ee9dbe2) <br><br>

Figure 2. Representative examples of training and test dataset

![Figure2](https://github.com/SenseableSpace/Utilizing-synthetic-images-to-enhance-the-automated-recognition-of-small-sized-construction-tools/assets/162809473/c47012f3-c52a-4ef2-b9fc-9484db13828a) <br><br>

### Results
Figure 3. Inference results - confidence scores of small-sized tools, ‘Hammer’

![Figure3](https://github.com/SenseableSpace/Utilizing-synthetic-images-to-enhance-the-automated-recognition-of-small-sized-construction-tools/assets/162809473/4621b66d-aa52-486d-a781-8fca9f5ef7b3) <br><br>

Figure 4. Inference results - confidence scores of small-sized tools, ‘Tacker'

![Figure4](https://github.com/SenseableSpace/Utilizing-synthetic-images-to-enhance-the-automated-recognition-of-small-sized-construction-tools/assets/162809473/24685b01-dfef-4701-84bf-000ed1bee39d) <br><br>

### Code Definition
| Category                 | Description                                                                           |
| ------------------------ | --------------------------------------------------                                    |
| `ScreenshotCapture.cs`   | This code has been used to automatically generate a group of synthetic images by capturing the screen while incrementally changing the viewing angles of a 3D object's x and y axes from 0° to 360° by 15° increments. |
| `YOLOv8_open.ipynb`      | This code has been used to develop the proposed vision-based classifiers (i.e., 'Real-4000,' 'Hybrid-4000,' and 'Hybrid-8000') for the automated recognition of small-sized construction tools. | <br><br>

### Data Availability Statements
Some or all data or code that support the findings of this study are available from the corresponding author upon reasonable request.
