# B-Spliner
B-Spliner is a tool that can be used to calculate and display spline curves using an implementation of the B-Spline algorithm. Your inputs for calculation are a set of control points, degree, and steps. At the moment this program does not allow custom input of knot vectors so it instead generates uniformly separated values for each knot.

![alt text](http://i.imgur.com/RaRTfOM.png "B-Spliner GUI")
![alt text](http://i.imgur.com/1TCKVkS.png "GNUPlot")

# How to Use
**Enter Control Points**

To enter a set of control points, simply start typing 3-dimensional coordinates in the left-most textbox labeled “Control Points”. Each line represents the x, y, and z values of a point and each point is separated by a new line.

*Note: View boundaries in GNUPlot are set to -100 to 100 for each axis.*

- Preset Control Points
 - In addition to allowing control points from user-input, B-Spliner also offers a selection of pre-defined control points which can be accessed by clicking on the dropdown scroll box labeled “Presets” and then clicking “Load”.

**Calculate B-Spline Curve**

Before you start your calculation you may input additional parameters such as degree and number of steps. Both of which are inputted in the top left inside “Calculation Options”. Once you have a set of valid control points entered you may then click the “CALCULATE POINTS (>>)” button to begin the recursive calculation to generate your B-spline coordinates.

**Plot Points in GNUPlot**

After you finally have sets for both control points and B-spline points, you may send those values to GNUPlot and run it by clicking the “PLOT POINTS (GNU)” button in the center. You may also modify whether GNUPlot draws just the points, lines connecting the points, both, or none by clicking the radio buttons at the bottom of the interface.

# System Requirements
- Windows 7 or above
- .NET Framework 4.5
- Visual Studio 2013
