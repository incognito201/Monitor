# Monitor
[![GitHub license](https://img.shields.io/github/license/incognito201/Monitor)](https://github.com/incognito201/Monitor/blob/master/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/incognito201/Monitor)](https://github.com/incognito201/Monitor/stargazers)

Constrói observables a partir de objetos que implementam INotifyPropertyChanged, INotifyCollectionChanged ou INotifyDataErrorInfo.

## Exemplos

- Monitorando uma propriedade de um item:
```cs
OrderItems = new WatchableCollection<OrderItem>();

OrderItems.WhenItemPropertyChanged(x => x.Quantity)
    .Subscribe(e =>
    {
        var item = e.Source;
        if(item.Quantity < 1)
        {
            item.AddError(e.PropertyName, "Invalid quantity!");
        }
        else
        {
            item.RemoveErrors(e.PropertyName);
        }
    });
```

- Monitorando múltiplas propriedades de um item
```cs
public decimal Total
{
    get => OrderItems.Sum(i => i.Quantity * i.Price);
}
```
```cs
OrderItems.WhenAnyItemPropertyChanged(x => x.Quantity, x => x.Price)
    .Subscribe(i =>
    {
        RaisePropertyChanged(nameof(Total));
    });
```

**Atenção:** Os observables precisam ser descartados após a inscrição para evitar vazamento de memória.

## Considerações
Essa biblioteca foi desenvolvida para ser utilizada em sistemas simples ou legados. Se você utiliza .NET Framework 4.6.1 ou superior considere utilizar ReactiveUI ou outra biblioteca mais robusta.
