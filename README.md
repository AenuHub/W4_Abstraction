## W4_Abstraction

### Overview
This project implements an abstract class `Employee` with two derived classes `ProjectManager`and `Designer`. The abstract class holds common values for derived classes such as `FirstName`, `LastName` and `Department`.

### Class Structure

#### 1. Employee (Abstract Class)
**Properties:**
- `FirstName` (str): The first name of the person.
- `LastName` (str): The last name of the person.
- `Department` (str): The department of the person works at.

**Methods:**
- `PrintPosition()`: This method is an abstract one, in order to override in inherited classes.

#### 2. ProjectManager (Inherits from `Employee`)

**Overridden Methods:**
- `PrintPosition()`: This method prints the name, surname, and working department to the console. It overrides the `PrintPosition()` method from `Employee` within it.

#### 3. Designer (Inherits from `Employee`)

**Overridden Methods:**
- `PrintPosition()`: This method prints the name, surname, and working department to the console. It overrides the `PrintPosition()` method from `Employee` within it.
