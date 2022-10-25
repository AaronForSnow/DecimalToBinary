Feature: Feature1

A short summary of the feature

@tag1
Scenario: Number given in Decimal
	Given The First Number Is 0
	When It Is Converted to Binary
	Then the number has become 0

Scenario Outline: Convert from Decimal to Binary
	Given The First Number Is <decimalin>
	When It Is Converted to Binary
	Then the number has become <binaryout>

	Examples: 
		| decimalin | binaryout          |
		| 1         | 1                  |
		| 2         | 10                 |
		| 7         | 111                |
		| 15        | 1111               |
		| 32        | 10000              |
		| 65        | 1000001            |
		| 125       | 1111101            |
		| 127       | 1111111            |
		| 128       | 10000000           |
		| 129       | 10000001           |
		| 1023      | 1111111111         |
		| 1024      | 10000000000        |
		| 1025      | 10000000001        |
		| 1032      | 10000001000        |
		| -1        | *throws execption* |
		| 1.1       | *throws execption* |

