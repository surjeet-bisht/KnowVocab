import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { MyDictionaryComponent } from './my-dictionary/my-dictionary.component';
import { ArticleDetailComponent } from './article-detail/article-detail.component';
import { CategoryArticlesComponent } from './category-articles/category-articles.component';
import { ProfileComponent } from './profile/profile.component';
import { FooterComponent } from './nav-menu/footer/footer.component';
import { DictionaryDetailComponent } from './dictionary-detail/dictionary-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    RegisterComponent,
    MyDictionaryComponent,
    ArticleDetailComponent,
    CategoryArticlesComponent,
    ProfileComponent,
    FooterComponent,
    DictionaryDetailComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'article-detail', component: ArticleDetailComponent },
      { path: 'my/words', component: MyDictionaryComponent },
      { path: 'profile', component: ProfileComponent },
      { path: 'word/detail', component: DictionaryDetailComponent },
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
