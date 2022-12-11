import {
  Component
} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  MataKuliah = 'Pemprograman Framework'

  GantiMatkul(){
    this.MataKuliah = 'Pemprograman Visual'
  }
}
