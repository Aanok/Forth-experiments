: ISFIZZ 3 MOD 0= ; ( n -- ? )
: ISBUZZ 5 MOD 0= ; ( n -- ? )
: FIZZBUZZ ( u -- )
	1 DO
	I ISFIZZ IF
		 ." fizz "
	ELSE
		I ISBUZZ IF
			." buzz "
		ELSE I .
		THEN
	THEN
	LOOP ;
