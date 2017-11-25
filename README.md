# 3. Test Driven Development
# 3.1 ReverseFile

This .Net Core console app is written in TDD approach which reverses a input text file. Program.cs treated outside TDD.

## Example:

### Input Text from input.txt:

```This is line one.```

```Second line.```

```Third line.```

### Output Generated in output.txt:

```.enil drihT```

```.enil dnoceS```

```.eno enil si sihT```

## Helpers:

Please add [these](https://github.com/banerjeea/ReverseFile/tree/master/HelperTextFiles) files to ```c:\temp``` to run the program. Due to time constraints, the program doesn't take file paths through user inputs. Also assumes you are running the app on a windows box.

## What I Googled:
```File.ReadAllLines(path)``` to find the easiest way to read each line of a file and store them in string array.

# 4. System Design

It's an application [design](https://github.com/banerjeea/ReverseFile/tree/master/SystemDesign) created under 10 minutes; given more time, I would have added an infrastructure design as well. 


