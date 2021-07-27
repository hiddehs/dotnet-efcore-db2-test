# Simple DB2 Tester .netcore Solution

## Usage

1. Clone repo
2. Build solution
3. Make sure db2 instance is running, for example via docker;
4. Run console app

### Run example db2 instance
```bash
docker run -itd --name mydb2 --privileged=true -p 50000:50000 -e LICENSE=accept -e DB2INST1_PASSWORD=testdbpassword -e DBNAME=testdb -v db2stor:/database ibmcom/db2
```