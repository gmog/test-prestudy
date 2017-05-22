*** Settings ***

*** Test Cases ****
My Test Case
	Tee Jotain
	Tee Jotain Muuta
	Tee Viela Jotain Muuta
	
*** Keywords ***
Tee Jotain
	Log	Log Message

Tee Jotain Muuta
	Log This is jotain muuta
	
Tee Viela Jotain Muuta
	Log This is viela jotain muuta
	
	