class producto{
    constructor(name, price, year) {
        this.name = name;
        this.price = price;
        this.year = year;
    }
}

class UI{
    addProduct(product){
        const productList = document.getElementById('product-list');
        const element = document.createElement('div');
        element.innerHTML = `
        <div class="card text-center mb-4">
            <div class="card-body">
            <strong>Product name</strong> : ${product.name}
            <strong>Product price</strong> : ${product.price}
            <strong>Product ano</strong> : ${product.year}
            <a class="btn btn-danger" name="delete">delete</a>
                </div>
        </div>
        `;
        productList.appendChild(element);
        this.resetForm();

    }

    resetForm(){
        document.getElementById('product-form').reset();
    }
    deleteProduct(element){
        if (element.name == 'delete') {
            element.parentElement.parentElement.parentElement.remove();
        }

    }
    showMessage(message, cssClass ){
      const div=  document.createElement('div');
      div.className = `alert alert-${cssClass}`;
      div.appendChild(document.createTextNode(message));

      //mostrar al DOM
     const container = document.querySelector('.container');
    const app = document.getElementById('app');
    container.insertBefore(div,app);

    }
}

//DOM
document.getElementById('product-form')
.addEventListener('submit', function (e) {
    
    const name = document.getElementById('name').value;
    const price = document.getElementById('price').value;
    const year = document.getElementById('year').value;

    
    const product = new producto(name,price,year);
    const ui = new UI();
    ui.addProduct(product);
    ui.showMessage('Producto agregado satisfactoriamente', 'success');
    
    e.preventDefault();
         
}
);
document.getElementById('product-list').addEventListener('click',function (e) {

    const iu = new UI();
    iu.deleteProduct(e.target);
    
});