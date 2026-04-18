
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { OrderStatusPipe } from '../../pipes/order-status-pipe';

@Component({
  selector: 'app-orders',
  standalone: true,
  imports: [CommonModule, OrderStatusPipe],
  templateUrl: './orders.html',
  styleUrl: './orders.css'
})
export class OrdersComponent {
  orders = [
    { id: 1, item: 'Laptop', price: 55000, date: new Date('2026-04-10'), status: 3 },
    { id: 2, item: 'Mouse', price: 250, date: new Date('2026-04-15'), status: 1 },
    { id: 3, item: 'Keyboard', price: 1500, date: new Date('2026-04-17'), status: 2 }
  ];

  getStatusColorClass(statusCode: number): string {
    switch (statusCode) {
      case 1: return 'bg-status-processing';
      case 2: return 'bg-status-shipped';
      case 3: return 'bg-status-delivered';
      default: return 'bg-status-unknown';
    }
  }
}