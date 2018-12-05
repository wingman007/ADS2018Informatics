package lexer;

public class TokenAttribute {
	private int intVal; // int value of the token
	private String idVal; // id of the token

	public TokenAttribute() {}

	// construct TokenAttribute with an int value
	public TokenAttribute(int intVal){
		this.intVal = intVal;
	}

	// construct TokenAttribute with an id
	public TokenAttribute(String idVal){
		this.idVal = idVal;
	}

	public int getIntVal() {
		return intVal;
	}

	public void setIntVal(int intVal) {
		this.intVal = intVal;
	}


	public String getIdVal() {
		return idVal;
	}
	
	public void setIdVal(String idVal) {
		this.idVal = idVal;
	}
}
