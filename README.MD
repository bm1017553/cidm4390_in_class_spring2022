# Semester Project Example

## Section 01 - Los Barrios

### Speaker Registration

`Console.WriteLine()`

```gherkin
Feature: Register Speaker

    As a speaker 
    I need to register for a speaker session
    So that my session will be scheduled

    Scenario: Speaker fills in contact information
    When the speaker fills in the first name field
    And the speaker fill sin the last name field
    Then the field should be validated such that only UTF-8 input is allowed

    Scenario: Speaker fills in contact information
    When the speaker fills in the email address field
    Then a regular expression should be applied to ensure that the email is well-formed

    

```