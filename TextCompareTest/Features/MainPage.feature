Feature: MainPage
	In order to quickly find differences in texts
	As a user
	I want to compare two texts

Background:
	Given the site is opened in the Google Chrome

Scenario Outline: Checking comparisong with two empty fields
	When I click Compare button
	Then the <message> should be on the screen

	Examples:
		| message                                           |
		| No text to compare makes my life easy! Cheers ;-) |

Scenario Outline: Checking Text Edit button's drop down options
	When I enter <text> in the left input field
	When I click on Edit Text button
	When I click <option> in Edit Text button
	When I click Compare button
	Then the <result> should be on the screen

	Examples:
		| text                                 | option                          | result                              |
		| Paste one version of a text here.    | To lowercase                    | paste one version of a text here.   |
		| paste one version\nof a text\nhere.  | Sort lines                      | paste one version\nof a text\nhere. |
		| paste one version\nof a text\nhere.  | Replace line breaks with spaces | paste one version of a text here.   |
		| Paste one version    of a text here. | Remove excess white space       | Paste one version of a text here.   |

Scenario Outline: Enter text in the left input field
	When I enter <text> in the left input field
	When I click Compare button
	Then the <result> should be on the screen

	Examples:
		| text                           | result                         |
		| Hello, world!                  | Hello, world!                  |
		| 123 456 7890                   | 123 456 7890                   |
		| !№;%:?*()_ += -@#$^&   /Привет | !№;%:?*()_ += -@#$^&   /Привет |

Scenario Outline: Enter text in the right input field
	When I enter <text> in the right input field
	When I click Compare button
	Then the <result> should be on the screen

	Examples:
		| text                       | result                     |
		| Hello, Ann!                | Hello, Ann!                |
		| 1233 456 7890              | 1233 456 7890              |
		| !№;%:?*()_ += -@#$^&Привет | !№;%:?*()_ += -@#$^&Привет |

Scenario Outline: Compare texts
	When I enter <text_left_field> in the left input field
	When I enter <text_right_field> in the right input field
	When I click Compare button
	Then the <result> is following

	Examples:
		| text_left_field | text_right_field | result          |
		| Hello 123       | Hello 123        | Same texts      |
		| 123$%^  789     | 123456  789      | Different texts |

Scenario Outline: Switch texts in fields
	When I enter <text_left_field> in the left input field
	When I click Switch Texts button
	When I click Compare button
	Then the <result_left> should be on the left input field
	Then the <result_right> should be on the right input field

	Examples:
		| text_left_field    | text_right_field    | result_left         | result_right       |
		| Text in left field | Text in right field | Text in right field | Text in left field |

Scenario Outline: Clear all texts from fields
	When I enter <text_left_field> in the left input field
	When I enter <text_right_field> in the right input field
	When I click Clear All button
	Then the <result_left> should be on the left input field
	Then the <result_right> should be on the right input field

	Examples:
		| text_left_field | text_right_field | result_left | result_right |
		| Some text       | Another text     |             |              |

Scenario Outline: Checking successful sending compared texts result
	When I enter <text_left_field> in the left input field
	When I enter <text_right_field> in the right input field
	When I click Compare button
	When I click Email This Comparisong button
	When I enter Email for send comparion results
	When I click Send It button
	Then the <result> should be on the screen

	Examples:
		| text_left_field    | text_right_field    | result                         |
		| Text in left field | Text in right field | Your comparison has been sent! |

Scenario Outline: Go to feedback page and send feedback
	When I click Feedback link
	When I enter Very comfortable tool in message field
	When I enter Email in the feedback page
	When I click Send Feedback button
	Then the <result> should be on the screen

	Examples:
		| result                               |
		| Your feedback has been sent! Thanks! |

Scenario Outline: Go to about page
	When I click About link
	Then the <result> should be on the screen

	Examples:
		| result                                                                                                                                                            |
		| Text Compare! does not save or share the text you compare. If you have sensitive information to compare, however, it is still recommended to use an offline tool. |