## Testing for AvailableClassifications


Boundary Tests

- Test for ageOfViewer = 11;
  - Expected U and PG 

- Test for ageOfViewer = 12, 14
  - Expected "U, PG, 12"
- Test for ageOfViewer = 15, 17
  - Expected "U, PG, 12, 15"
- Test for ageOfViewer = 18, 19
  - Expected "All films are available"

Extreme Cases

- Test for ageOfViewer = 0
  - "Expected U and PG"

- Test for ageOfViewer = 1000
  - Expected "All films are available"