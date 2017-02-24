: ?1 ( n -- n ? )
	DUP 1 = ;

: COLLSTEP ( n -- n )
	DUP 2 MOD IF 3 * 1 + ELSE 2 / THEN ;

: COLLATZ ( n -- )
	BEGIN COLLSTEP DUP . ?1 UNTIL DROP ;
