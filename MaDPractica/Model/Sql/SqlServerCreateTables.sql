USE [practicaMaD]

DROP TABLE Comentario;
DROP TABLE Properties;
DROP TABLE Lineas;
DROP TABLE Orders;
DROP TABLE Credit_card;
DROP TABLE Product;
DROP TABLE Tag;
DROP TABLE Category;
DROP TABLE Property;
DROP TABLE Custumer;

CREATE TABLE Custumer(

    custumer_id NUMBER(10) NOT NULL,
    custumer_name VARCHAR(50) NOT NULL,
    custumer_last_name1 VARCHAR(50) NOT NULL,
    custumer_last_name2 VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    idioma VARCHAR(50),
    country VARCHAR(50),
    rol VARCHAR(50),
    credit_card_default VARCHAR(50) NOT NULL,
    custumer_login VARCHAR(50) NOT NULL,

    CONSTRAINT custumerPK PRIMARY KEY (custumer_id)

);

CREATE TABLE Orders(

    order_id NUMBER(10) NOT NULL,
    order_date DATE,
    direccion VARCHAR(50) NOT NULL,
    total_price NUMBER(10) NOT NULL,
    descripcion VARCHAR(100),
    custumer_id NUMBER(10) NOT NULL
    
    CONSTRAINT OrdersPK PRIMARY KEY (order_id),

    CONSTRAINT custumer_idFK
     FOREIGN KEY (custumer_id)
     REFERENCES Custumer(custumer_id)

);

CREATE TABLE Credit_card(

    credit_card_number_int VARCHAR(50) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    cvs NUMBER(3) NOT NULL,
    date_pf_expiry DATE NOT NULL,
    custumer_id NUMBER(10) NOT NULL,

    CONSTRAINT Creadit_cardPK PRIMARY KEY (credit_card_number_int),

    CONSTRAINT custumer_idFK2
     FOREIGN KEY (custumer_id)
     REFERENCES Custumer(custumer_id)

);

CREATE TABLE Product(

    product_id NUMBER(10) NOT NULL,
    product_name VARCHAR(50) NOT NULL,
    price NUMBER(10) NOT NULL,
    discharge_date DATE,
    stock NUMBER(10) NOT NULL,
    descripcion VARCHAR(100),
    category_id NUMBER(10) NOT NULL,

    CONSTRAINT ProductPK PRIMARY KEY (product_id),

    CONSTRAINT categry_idFK
     FOREIGN KEY (category_id)
     REFERENCES Category(category_id)

);

CREATE TABLE Category(

    type_id NUMBER(10) NOT NULL,
    type_name VARCHAR(50) NOT NULL,
    CONSTRAINT CategoryPK PRIMARY KEY (type_id)

);

CREATE TABLE Producto_por_pedido(

    order_id NUMBER(10) NOT NULL,
    product_id NUMBER(10) NOT NULL,
    units NUMBER(10) NOT NULL,
    price_unit NUMBER(10) NOT NULL,

    CONSTRAINT LineasPK PRIMARY KEY (order_id,product_id),

    CONSTRAINT order_idFK 
     FOREIGN KEY (order_id)
     REFERENCES Orders(order_id),

    CONSTRAINT product_idFK
     FOREIGN KEY (product_id)
     REFERENCES Product(product_id)

);

CREATE TABLE Tag(

    tag_id NUMBER(10) NOT NULL,
    tag VARCHAR(50) NOT NULL,

    CONSTRAINT TagPK PRIMARY KEY (tag_id)
);

CREATE TABLE Property(

    property_id NUMBER(10) NOT NULL,
    property_name VARCHAR(50) NOT NULL,
    property_value VARCHAR(50) NOT NULL,

    CONSTRAINT PropertyPK PRIMARY KEY (property_id)

);

CREATE TABLE Properties(

    product_id NUMBER(10) NOT NULL,
    property_id NUMBER(10) NOT NULL,
    properties_value VARCHAR(50) NOT NULL,

    CONSTRAINT PropertiesPK PRIMARY KEY (product_id,property_id),

    CONSTRAINT product_idFK2 
     FOREIGN KEY (product_id)
     REFERENCES Product(product_id),

    CONSTRAINT property_idFK
     FOREIGN KEY (property_id)
     REFERENCES Property(property_id)

);

CREATE TABLE Comenta(

    custumer_id NUMBER(10) NOT NULL,
    product_id NUMBER(10) NOT NULL,
    tag NUMBER(10) NOT NULL,
    comment VARCHAR(50) NOT NULL,
    fecha DATE,

    CONSTRAINT ComentarioPK PRIMARY KEY (custumer_id,product_id,tag),

    CONSTRAINT custumer_idFK3
     FOREIGN KEY (custumer_id)
     REFERENCES Custumer(custumer_id),

    CONSTRAINT product_idFK3
     FOREIGN KEY (product_id)
     REFERENCES Product(product_id),

    CONSTRAINT tagFK
     FOREIGN KEY (tag)
     REFERENCES Tag(tag_id)

);