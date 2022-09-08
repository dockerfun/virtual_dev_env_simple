import { Component } from '@angular/core';
import { setTheme } from 'ngx-bootstrap/utils';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  loadedFeature = 'user';

  constructor() {
    setTheme('bs3');
  }

  onNavigate(feature: string) {
    this.loadedFeature = feature;
  }
}
